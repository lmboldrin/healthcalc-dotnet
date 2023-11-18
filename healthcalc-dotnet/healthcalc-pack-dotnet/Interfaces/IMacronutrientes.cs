using healthcalc_pack_dotnet.Enums;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_pack_dotnet.Interfaces
{
    public interface IMacronutrientes
    {
        ResultadoMacronutrientesModel CalcularMacroNutrientes(double peso, ObjetivoFisicoEnum objetivoFisico);
    }
}
