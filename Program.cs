using System;
using juros.Models;

Console.Write("Digite o valor principal (P): ");
double principal = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a taxa de juros (i): ");
double taxaJuros = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o número de períodos (n): ");
int periodos = Convert.ToInt32(Console.ReadLine());

// Cria uma instância do JurosSimples e define suas propriedades
JurosSimples juros = new JurosSimples
{
    Principal = principal,
    TaxaJuros = taxaJuros,
    Periodos = periodos
};


JurosCompostos jComp = new JurosCompostos
{
    Principal = principal,
    TaxaJuros = taxaJuros,
    Periodos = periodos
    };

// Calcula o montante final utilizando a função da Model
double montanteFinal = juros.CalcularJurosSimples();
double montanteFinal2 = jComp.CalcularJurosCompostos();

// Exibe o resultado
Console.WriteLine($"O montante final com juros simples é: {montanteFinal}");
Console.WriteLine($"O montante final com juros compostos é: {montanteFinal2}");
