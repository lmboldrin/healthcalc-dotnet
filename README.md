# HealthCalc

## Descrição

O HealthCalc-dotnet é uma calculadora de IMC e Macronutrientes desenvolvido para fins acadêmicos. Seu propósito é calcular e retornar o IMC, classificação do IMC e também calcula os macronutrientes de acordo com o objetivo desejado (Cutting, Bulking, Manter peso)

## Funcionamento

### Cálculo do IMC

O IMC é calculado usando a fórmula IMC = peso (kg) / (altura (m) * altura (m)). 

### Cálculo de Macronutrientes

A quantidade de Macronutrientes (gorduras, proteínas e carboidratos) é calculada com base nos objetivos do usuário  (Cutting, Bulking, Manter peso).

## Observações

Este projeto foi desenvolvidos para fins acadêmidos a fim de colocar em prática conceitos aprendidos durante uma oferta de curso. Não deve ser utilizado como auxílio em dietas ou acompanhamentos nutricionais.

## Pré-requisitos

- .NET 8.0 
- Visual Studio 2019 ou posterior.

## Estrutura do Projeto

```
healthcalc-dotnet/
|-- healthcalc-console-dotnet
|-- healthcalc-pack-dotnet
|-- healthcalc-test
```

## Uso do Pacote

Para instalar o pacote mais atual utilize o seguinte comando:

```
dotnet add package healthcalc-dotnet --version 1.1.0
```
