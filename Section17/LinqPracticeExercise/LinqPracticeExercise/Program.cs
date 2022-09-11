using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using LinqPracticeExercise.Entities;

namespace LinqPracticeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Fazer um programa para ler os dados(nome, email e salário)
            //de funcionários a partir de um arquivo em formato.csv.
            //Em seguida mostrar, em ordem alfabética, o email dos
            //funcionários cujo salário seja superior a um dado valor
            //fornecido pelo usuário.
            //Mostrar também a soma dos salários dos funcionários cujo
            //nome começa com a letra 'M'.

            //Input file
            //Maria,maria @gmail.com,3200.00
            //Alex,alex @gmail.com,1900.00
            //Marco,marco @gmail.com,1700.00
            //Bob,bob @gmail.com,3500.00
            //Anna,anna @gmail.com,2800.00

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double refSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            var emails = employees.Where(e => e.Salary > refSalary).OrderBy(e => e.Email).DefaultIfEmpty().Select(e => e.Email);

            Console.WriteLine("Email of people whose salary is more than " + refSalary.ToString("F2", CultureInfo.InvariantCulture) + ":");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            var salaryAvg = employees.Where(e => e.Name[0] == 'M').DefaultIfEmpty().Select(e => e.Salary).Sum();

            Console.WriteLine("Sum of salary of people whose name starts with 'M' :" + salaryAvg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
