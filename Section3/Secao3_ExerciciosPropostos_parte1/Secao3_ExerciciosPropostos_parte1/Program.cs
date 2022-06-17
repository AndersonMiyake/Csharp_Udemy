using System;
using System.Globalization;

namespace Secao3_ExerciciosPropostos_parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1();
            //exercicio2();
            //exercicio3();
            //exercicio4();
            //exercicio5();
            exercicio6();

        }

        static void exercicio1()
        {
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            //mensagem explicativa, conforme exemplos.

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("SOMA = {0}", n1 + n2);
        }

        static void exercicio2()
        {
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            //casas decimais conforme exemplos.
            //Fórmula da área: area = π.raio2
            //Considere o valor de π = 3.14159

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("A = {0}", area.ToString("F4", CultureInfo.InvariantCulture));

        }

        static void exercicio3()
        {
            //Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }

        static void exercicio4()
        {
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais.

            int funcId = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double salarioPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioTotal = horasTrabalhadas * salarioPorHora;

            Console.WriteLine("NUMBER = " + funcId);
            Console.WriteLine("SALARY = U$ {0}", salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void exercicio5()
        {
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

            string[] peca1 = Console.ReadLine().ToString(CultureInfo.InvariantCulture).Split(' ');
            string[] peca2 = Console.ReadLine().ToString(CultureInfo.InvariantCulture).Split(' ');

            int codPeca1 = int.Parse(peca1[0]);
            int qtdePeca1 = int.Parse(peca1[1]);
            double valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            int codPeca2 = int.Parse(peca2[0]);
            int qtdePeca2 = int.Parse(peca2[1]);
            double valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double total = qtdePeca1 * valorPeca1 + qtdePeca2 * valorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void exercicio6()
        {
            //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e
            //mostre:
            //a) a área do triângulo retângulo que tem A por base e C por altura.
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B.

            string[] array = Console.ReadLine().ToString(CultureInfo.InvariantCulture).Split(' ');

            double A = double.Parse(array[0], CultureInfo.InvariantCulture);
            double B = double.Parse(array[1], CultureInfo.InvariantCulture);
            double C = double.Parse(array[2], CultureInfo.InvariantCulture);

            double triangulo = (A * C) / 2;
            double circulo = Math.PI * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;        // or (A + B) / 2.0 * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
