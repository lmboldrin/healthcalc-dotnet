using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Enums;
using healthcalc_pack_dotnet.Interfaces;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_test_dotnet.Pack
{
    public class MacronutrientesTest
    {
        [Theory]
        [InlineData(ObjetivoFisicoEnum.Cutting, 170.0, 85.0, 170.0)]
        [InlineData(ObjetivoFisicoEnum.Bulking, 170.0, 85.0, 340.0)]
        [InlineData(ObjetivoFisicoEnum.Keep, 170.0, 85.0, 425.0)]
        public void CalcularMacronutrientes_QuandoObjetivoValido_EntaoRetornaObjetoComMacros(ObjetivoFisicoEnum objetivo, double proteinas, double gorduras, double carboidratos)
        {
            //Arrange
            var macros = new Macronutrientes();
            const double peso = 85;
            var macrosEsperados = new ResultadoMacronutrientesModel
            {
                Proteinas = proteinas,
                Gorduras = gorduras,
                Carboidratos = carboidratos
            };

            //Act
            var resultadosMacros = macros.CalcularMacroNutrientes(peso, objetivo);

            //Asserts
            Assert.Equivalent(macrosEsperados, resultadosMacros);
        }
        

        [Fact]
        public void CalcularMacronutrientes_QuandoObjetivoInvalido_EntaoRetornaException()
        {
            //Arrange
            var macros = new Macronutrientes();
            const double peso = 85;

            //Act
            void Act() => macros.CalcularMacroNutrientes(peso, Enum.Parse<ObjetivoFisicoEnum>("Entrada invalida"));

            //Asserts
            Assert.Throws<ArgumentException>(Act);
        }

    }
}