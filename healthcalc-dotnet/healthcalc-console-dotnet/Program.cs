using healthcalc_pack_dotnet;

var objeto = new Imc();

var imc = objeto.CalcularImc(85, 1.70);
var resultado = objeto.RetornarClassificacaoImc(imc);

Console.WriteLine($"Seu resultado é: {resultado}");
