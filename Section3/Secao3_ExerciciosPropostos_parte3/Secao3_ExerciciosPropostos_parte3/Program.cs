using System;

namespace Secao3_ExerciciosPropostos_parte3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            ex3();
        }

        static void ex1()
        {
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            int password = int.Parse(Console.ReadLine());

            while (password != 2002)
            {
                Console.WriteLine("Incorrect password");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Access guaranteed");
        }

        static void ex2()
        {
            //Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
            //cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            //menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).

            string[] points = Console.ReadLine().Split(' ');

            int x = int.Parse(points[0]);
            int y = int.Parse(points[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("First quadrant");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Second quadrant");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Third quadrant");
                }
                else
                {
                    Console.WriteLine("Forth quadrant");
                }

                points = Console.ReadLine().Split(' ');

                x = int.Parse(points[0]);
                y = int.Parse(points[1]);
            }

        }

        static void ex3()
        {
            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            //que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            //exemplo.


            int code = int.Parse(Console.ReadLine());
            int[] fuelType = { 0, 0, 0 };   //0- Ethanol | 1- Gasoline | 2- Diesel


            while (code != 4)
            {
                switch (code)
                {
                    case 1:
                        fuelType[0]++;
                        break;
                    case 2:
                        fuelType[1]++;
                        break;
                    case 3:
                        fuelType[2]++;
                        break;
                    default:
                        break;
                }
                code = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank you for your custom!");
            Console.WriteLine("Ethanol: " + fuelType[0]);
            Console.WriteLine("Gasoline: {0}", fuelType[1]);
            Console.WriteLine($"Diesel: {fuelType[2]}");

        }
    }
}
