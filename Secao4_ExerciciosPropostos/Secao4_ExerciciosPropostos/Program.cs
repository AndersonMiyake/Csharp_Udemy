using System;
using System.Globalization;

namespace Secao4_ExerciciosPropostos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            ex3();
        }

        public static void ex1()
        {
            //Fazer um programa para ler os valores da largura e altura de um retângulo. Em
            //seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe
            //como mostrado no projeto ao lado

            Rectangle r = new Rectangle();

            Console.WriteLine("Enter the width and the height of a rectangle:");
            r.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETER: " + r.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex2()
        {
            //Fazer um programa para ler os dados de um funcionário(nome,
            //salário bruto e imposto). Em seguida, mostrar os dados do
            //funcionário(nome e salário líquido).Em seguida, aumentar o salário
            //do funcionário com base em uma porcentagem dada(somente o
            //salário bruto é afetado pela porcentagem) e mostrar novamente os
            //dados do funcionário.Use a classe projetada abaixo.

            Employee e = new Employee();

            Console.Write("Name: ");
            e.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            e.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            e.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Employee: " + e);

            Console.WriteLine();
            Console.Write("Enter the percentage to raise the salary: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            e.RaiseSalary(percentage);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + e);
        }

        public static void ex3()
        {
            //Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            //(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).Ao final, mostrar qual a nota final do aluno no
            //ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            //para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver
            //este problema.

            Student s = new Student();

            Console.Write("Student name: ");
            s.Name = Console.ReadLine();

            Console.WriteLine("Enter the three grades of the student:");
            s.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("FINAL GRADE = " + s.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));
            if (s.Approved())
            {
                Console.WriteLine("APPROVED");
            }
            else
            {
                Console.WriteLine("FAILED\n {0} POINTS LEFT", s.PointsLeft().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
