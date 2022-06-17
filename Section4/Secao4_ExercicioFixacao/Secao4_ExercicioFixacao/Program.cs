using System;
using System.Globalization;

namespace Secao4_ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
            //uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
            //que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
            //para ser responsável pelos cálculos.

            Console.Write("What's the dollar rate? ");
            double rate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many dollars will you buy? ");
            double dollars = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Amount to be paid in reais: ");
            Console.WriteLine(CoinConverter.CalculateTotal(rate, dollars).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
