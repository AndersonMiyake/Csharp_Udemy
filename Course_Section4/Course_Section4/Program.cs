using System;
using System.Globalization;

namespace Course_Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 38 - Resolvendo um problema sem orientação a objetos

            //double xA, xB, xC, yA, yB, yC;

            //Console.WriteLine("Entre com as medidas do triângulo X:");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y:");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}

            #endregion


            #region 39 - Criando uma classe com três atributos para representar melhor um Triângulo e 41 - Criando um método para obtermos os benefícios de reaproveitamento e delegação

            //Triangulo x, y;

            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triângulo X:");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y:");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double areaX = x.Area();
            //double areaY = y.Area();

            //Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}
            #endregion

            #region 42 - Começando a resolver um segundo problema exemplo e 43 - Object e ToString e 44 - Terminando de construir o programa

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);


            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            #endregion

            #region 
            #endregion

            #region 
            #endregion

            #region 
            #endregion

            #region 
            #endregion
        }
    }
}
