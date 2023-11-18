namespace healthcalc_pack_dotnet.Interfaces
{
    public interface IImc
    {
        double CalcularImc(double peso, double altura);
        string RetornarClassificacaoImc(double imc);
    }
}
