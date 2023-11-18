# HealthCalc

## Descrição

O HealthCalc-dotnet é uma calculadora de IMC e Macronutrientes desenvolvido para fins acadêmicos. Seu propósito é calcular e retornar o IMC, classificação do IMC e também calcula os macronutrientes de acordo com o objetivo desejado (Cutting, Bulking, Manter peso)

## Funcionamento

### Cálculo do IMC

O IMC é calculado usando a fórmula IMC = peso (kg) / (altura (m) * altura (m)). 

### Cálculo de Macronutrientes

A quantidade de Macronutrientes (gorduras, proteínas e carboidratos) é calculada com base nos objetivos do usuário  (Cutting, Bulking, Manter peso).

## Observações

Este projeto foi desenvolvidos para fins acadêmicos a fim de colocar em prática conceitos aprendidos durante uma oferta de curso. Não deve ser utilizado como auxílio em dietas ou acompanhamentos nutricionais.

## Pré-requisitos

- .NET 8.0 
- Visual Studio 2019 ou posterior.

## Uso do Pacote

Para instalar o pacote mais atual utilize o seguinte comando:

```
dotnet add package healthcalc-dotnet --version 1.1.0
```

## Métodos IMC

### **CalcularImc**
```
double CalcularImc(double peso, double altura)
```
Calcula o Índice de Massa Corporal (IMC) com base no peso e altura fornecidos.

Parâmetros:
- **peso:** Peso em quilogramas.
- **altura:** Altura em metros.

Retorna:
- double: Valor calculado do IMC.

#
### **RetornarClassificacaoImc**
```
string RetornarClassificacaoImc(double imc)
```
Retorna a classificação do estado ponderal com base no valor do IMC fornecido.

Parâmetros: 
- **imc:** Valor do Índice de Massa Corporal (IMC)

Retorna:
- string: Classificação do IMC

#
### **Exceptions**
- **Altura Invalida Exception**: será lançada se a altura for igual a zero
- **Peso Invalido Exception**: será lançada se o peso for igual a zero

## Exemplo de Uso:

```
using healthcalc_pack_dotnet;

class Program
{
    static void Main()
    {
        // Crie uma instância da classe Imc
        var calculadoraImc = new Imc();

        // Calcule o IMC
        double peso = 70; // em quilogramas
        double altura = 1.75; // em metros
        double imc = calculadoraImc.CalcularImc(peso, altura);

        // Exiba o IMC
        Console.WriteLine($"Seu IMC é: {imc}");

        // Obtenha a classificação do IMC
        string classificacao = calculadoraImc.RetornarClassificacaoImc(imc);

        // Exiba a classificação do IMC
        Console.WriteLine($"Classificação: {classificacao}");
    }
}
```

## Método Macronutrientes:

### **CalcularMacroNutrientes**
```
ResultadoMacronutrientesModel CalcularMacroNutrientes(double peso, ObjetivoFisicoEnum objetivoFisico)
```

Parâmetros:
- **peso**: Peso em Quilogramas
- **objetivoFisico (ObjetivoFisicoEnum):** Enum que representa o objetivo físico (Bulking, Cutting ou Keep).

Retorno:
- **ResultadoMacronutrientesModel**: Objeto contendo as quantidades calculadas de proteínas, gorduras e carboidratos.

## Exemplo de Uso:
```
using healthcalc_pack_dotnet;

class Program
{
    static void Main()
    {
        // Crie uma instância da classe Macronutrientes
        var calculadoraMacronutrientes = new Macronutrientes();

        // Informações do usuário
        double peso = 70; // em quilogramas
        ObjetivoFisicoEnum objetivo = ObjetivoFisicoEnum.Bulking;

        // Calcule os macronutrientes
        ResultadoMacronutrientesModel resultado = calculadoraMacronutrientes.CalcularMacroNutrientes(peso, objetivo);

        // Exiba os resultados
        Console.WriteLine($"Proteínas: {resultado.Proteinas}g");
        Console.WriteLine($"Gorduras: {resultado.Gorduras}g");
        Console.WriteLine($"Carboidratos: {resultado.Carboidratos}g");
    }
}
```
