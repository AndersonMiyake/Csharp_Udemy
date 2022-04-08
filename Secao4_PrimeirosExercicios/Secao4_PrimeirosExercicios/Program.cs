using System;
using System.Globalization;

namespace Secao4_PrimeirosExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            ex2();
        }

        static void ex1()
        {
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            //velha.

            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("Data for the first person:");
            Console.Write("Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nData for the second person:");
            Console.Write("Name: ");
            p2.Name = Console.ReadLine();
            Console.Write("Age: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age == p2.Age)
            {
                Console.WriteLine("{0} and {1} have the same age.", p1.Name, p2.Name);
            }
            else if (p1.Age > p2.Age)
            {
                Console.WriteLine("Older person: " + p1.Name);
            }
            else
            {
                Console.WriteLine("Older person: " + p2.Name);
            }
        }

        static void ex2()
        {
            //Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar o salário
            //médio dos funcionários.

            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("Data for the first employee:");
            Console.Write("Name: ");
            e1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            e1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nData for the second employee:");
            Console.Write("Name: ");
            e2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            e2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avrgSalary = (e1.Salary + e2.Salary) / 2.0;

            Console.WriteLine("Average salary: " + avrgSalary.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
