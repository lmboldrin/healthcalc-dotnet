using healthcalc_pack_dotnet;

namespace healthcalc_test_dotnet.Pack
{
    public class ImcTest
    {
        [Fact]
        public void CalculaImc_QuandoPesoEAlturaValidos_EntaoRetornaIndice()
        {
            //Arrange
            var imc = new Imc();
            const double peso = 85;
            const double altura = 1.70;
            const double indiceImc = 29.41;

            //Act
            var indiceImcRetornado = imc.CalcularImc(peso, altura);

            //Asserts
            Assert.Equal(indiceImc, indiceImcRetornado);

        }

        [Fact]
        public void CalculaImc_QuandoAlturaInvalido_EntaoRetornaExcecao()
        {
            //Arrange
            var imc = new Imc();
            const double peso = 85;
            const double altura = 0;

            //Act
            void Act() => imc.CalcularImc(peso, altura);

            //Asserts
            var ex = Assert.Throws<Exception>(Act);
            Assert.Equal("Altura Inválida!",ex.Message);
        }

        [Fact]
        public void CalculaImc_QuandoPesoInvalido_EntaoRetornaExcecao()
        {
            //Arrange
            var imc = new Imc();
            const double peso = 0;
            const double altura = 1.70;

            //Act
            void Act() => imc.CalcularImc(peso, altura);

            //Asserts
            var ex = Assert.Throws<Exception>(Act);
            Assert.Equal("Peso Inválido!",ex.Message);
        }

        [Theory]
        [InlineData(18.00, "ABAIXO DO PESO")]
        [InlineData(18.60, "PESO NORMAL")]
        [InlineData(24.90, "PESO NORMAL")]
        [InlineData(25.00, "SOBREPESO")]
        [InlineData(29.90, "SOBREPESO")]
        [InlineData(30.00, "OBESIDADE I")]
        [InlineData(34.90, "OBESIDADE I")]
        [InlineData(35.00, "OBESIDADE II")]
        [InlineData(39.90, "OBESIDADE II")]
        [InlineData(40.00, "OBESIDADE III")]
        public void RetornaClassificacaoImc_AcimaDoPeso_QuandoIndiceDentroDaFaixa(double indiceImc, string classificacao)
        {
            //Arrange
            var imc = new Imc();
            
            //Act
            var classificacaoRetornada = imc.RetornarClassificacaoImc(indiceImc);

            //Asserts
            Assert.Equal(classificacao, classificacaoRetornada);
        }
    }
}