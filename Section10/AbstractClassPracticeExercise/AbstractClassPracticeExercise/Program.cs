using System;
using System.Globalization;
using System.Collections.Generic;
using AbstractClassPracticeExercise.Entities;

namespace AbstractClassPracticeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char indOrComp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (indOrComp == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, healthExpend));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            double totalTaxes = 0.0;

            Console.WriteLine("\nTAXES PAID:");
            foreach (TaxPayer tp in taxPayers)
            {
                Console.WriteLine($"{tp.Name}: $ {tp.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += tp.Tax();
            }

            Console.WriteLine("\nTOTAL TAXES: $" + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
