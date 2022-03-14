using System;
using System.Globalization;

namespace Secao3_ExerciciosPropostos_parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio01();
            //exercicio02();
            //exercicio03();
            //exercicio04();
            //exercicio05();
            //exercicio06();
            //exercicio07();
            exercicio08();
        }

        static void exercicio01()
        {
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }

        static void exercicio02()
        {
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }

        static void exercicio03()
        {
            //Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            //ordem crescente ou decrescente.

            string[] numeros = Console.ReadLine().Split(' ');

            int a = int.Parse(numeros[0]);
            int b = int.Parse(numeros[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }

        static void exercicio04()
        {
            //Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            string[] horarios = Console.ReadLine().Split(' ');

            int h1 = int.Parse(horarios[0]);
            int h2 = int.Parse(horarios[1]);

            int duracao;

            if (h1 < h2)
            {
                duracao = h2 - h1;
            }
            else
            {
                duracao = h2 + 24 - h1;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
        }

        static void exercicio05()
        {
            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.A
            //seguir, calcule e mostre o valor da conta a pagar.

            string[] valores = Console.ReadLine().Split(' ');

            int cod = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double preco = 0.0;

            if (cod == 1)
                preco = 4.00;
            else if (cod == 2)
                preco = 4.50;
            else if (cod == 3)
                preco = 5.00;
            else if (cod == 4)
                preco = 2.00;
            else if (cod == 5)
                preco = 1.50;

            double total = preco * qtd;

            //double total;
            //if (codigo == 1)
            //{
            //    total = quantidade * 4.0;
            //}
            //else if (codigo == 2)
            //{
            //    total = quantidade * 4.5;
            //}
            //else if (codigo == 3)
            //{
            //    total = quantidade * 5.0;
            //}
            //else if (codigo == 4)
            //{
            //    total = quantidade * 2.0;
            //}
            //else
            //{
            //    total = quantidade * 1.5;
            //}

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static void exercicio06()
        {
            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            //seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            //nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number < 0.0 || number > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (number <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (number <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (number <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }

        static void exercicio07()
        {
            //Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            //de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            //ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            //Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            //situação.

            string[] valores = Console.ReadLine().Split(' ');

            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }

        static void exercicio08()
        {
            //Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            //que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            //qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.
            //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            //mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
            //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8 % apenas sobre R$ 1000.00, pois a faixa de
            //salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é
            //de 8 % sobre R$ 1000.00

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto = 0.00;

            if (salario <= 2000.00)
            {
                imposto = 0.00;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = 1000.00 * 0.08;
                imposto += (salario - 3000.00) * 0.18;
            }
            else if (salario > 4500.00)
            {
                imposto = 1000.00 * 0.08;
                imposto += 1500.00 * 0.18;
                imposto += (salario - 4500.00) * 0.28;
            }


            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ {0}", imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

    }
}
