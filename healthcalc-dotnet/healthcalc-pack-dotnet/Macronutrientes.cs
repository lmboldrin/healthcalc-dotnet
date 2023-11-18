using healthcalc_pack_dotnet.Enums;
using healthcalc_pack_dotnet.Interfaces;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_pack_dotnet
{
    public class Macronutrientes : IMacronutrientes
    {
        public ResultadoMacronutrientesModel CalcularMacroNutrientes(double peso, ObjetivoFisicoEnum objetivoFisico)
        {
            var resultado = new ResultadoMacronutrientesModel();

            switch (objetivoFisico)
            {
                case ObjetivoFisicoEnum.Bulking:
                    resultado.Proteinas = 2.0 * peso;
                    resultado.Gorduras = 1.0 * peso;
                    resultado.Carboidratos = 4.0 * peso;
                    break;
                case ObjetivoFisicoEnum.Cutting:
                    resultado.Proteinas = 2.0 * peso;
                    resultado.Gorduras = 1.0 * peso;
                    resultado.Carboidratos = 2.0 * peso;
                    break;
                case ObjetivoFisicoEnum.Keep:
                    resultado.Proteinas = 2.0 * peso;
                    resultado.Gorduras = 1.0 * peso;
                    resultado.Carboidratos = 5.0 * peso;
                    break;
            }
            return resultado;
        }
    }
}
