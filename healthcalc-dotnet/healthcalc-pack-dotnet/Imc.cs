using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_pack_dotnet
{
    public class Imc : IImc
    {
        public double CalcularImc(double peso, double altura)
        {
            if (altura == 0)
                throw new Exception("Altura Inválida!");
            if (peso == 0)
                throw new Exception("Peso Inválido!");
            
            var imc = peso / Math.Pow(altura, 2);
            return Math.Round(imc, 2);
        }

        public string RetornarClassificacaoImc(double imc)
        {
            return imc switch
            {
                <= 18.5 => "ABAIXO DO PESO",
                >= 18.6 and <= 24.9 => "PESO NORMAL",
                > 24.9 and <= 29.9 => "SOBREPESO",
                > 29.9 and <= 34.9 => "OBESIDADE I",
                > 34.9 and <= 39.9 => "OBESIDADE II",
                _ => "OBESIDADE III"
            };
        }
    }
}
