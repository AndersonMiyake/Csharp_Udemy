using System;
using System.Globalization;

namespace Secao3_ExerciciosPropostos_parte4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            ex7();
        }

        static void ex1()
        {
            //Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            //X, se for o caso

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void ex2()
        {
            //Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            int n = int.Parse(Console.ReadLine());

            int numbersInsideInterval = 0;
            int numbersOutsideInterval = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 10 && number <= 20)
                    numbersInsideInterval++;
                else
                    numbersOutsideInterval++;
            }

            Console.WriteLine(numbersInsideInterval + " in");
            Console.WriteLine("{0} out", numbersOutsideInterval);

        }

        static void ex3()
        {
            //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            //de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            //conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            //peso 5.

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                double n1 = double.Parse(values[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(values[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(values[2], CultureInfo.InvariantCulture);

                double result = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

                Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        static void ex4()
        {
            //Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            //segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                double n1 = double.Parse(values[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(values[1], CultureInfo.InvariantCulture);

                if (n2 != 0)
                {
                    Console.WriteLine(n1 / n2);
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }

        static void ex5()
        {
            //Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
            //Lembrando que, por definição, fatorial de 0 é 1.

            int n = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }

        static void ex6()
        {
            //Ler um número inteiro N e calcular todos os seus divisores.

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ex7()
        {
            //Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            //exemplo.

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} {1} {2}", i, Math.Pow(i,2), Math.Pow(i,3));
            }
        }



    }
}
