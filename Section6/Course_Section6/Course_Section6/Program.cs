using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course_Section6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 66. Tipos referência e tipos valor
            //Point p;
            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);

            //p = new Point();
            //Console.WriteLine(p);
            #endregion

            #region 68. Nullable

            //Nullable<double> x = null;
            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("X is null.");

            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("Y is null.");

            //Parte 2 da aula
            //double? x = null;
            //double? y = 10;

            //double a = x ?? 5;
            //double b = y ?? 5;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region 69. Vetores - PARTE 1

            //int n = int.Parse(Console.ReadLine());

            //double[] vect = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double sum = 0.0;
            //for(int i = 0; i < n; i++)
            //{
            //    sum += vect[i];
            //}

            //double avg = sum / n;

            //Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2",CultureInfo.InvariantCulture));

            #endregion

            #region 70. Vetores - PARTE 2

            //int n = int.Parse(Console.ReadLine());

            //Product[] vect = new Product[n];

            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new Product { Name = name, Price = price }; 
            //}

            //double sum = 0.00;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i].Price;
            //}

            //double avg = sum / n;

            //Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region 72. Modificador de parâmetros params
            //int s1 = Calculator.Sum(2, 3);
            //int s2 = Calculator.Sum(2, 4, 3);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            #endregion

            #region 73. Modificadores de parâmetros ref e out
            //int a = 10;
            //Calculator.Triple(ref a);
            //Console.WriteLine(a);

            //int a = 10;
            //int triple;
            //Calculator.Triple(a, out triple);
            //Console.WriteLine(triple);
            #endregion

            #region 75. Sintaxe opcional: laço foreach

            //string[] vect = new string[] { "Maria", "Alex", "Bob" };

            //for (int i = 0; i < vect.Length; i++)
            //{
            //    Console.WriteLine(vect[i]);
            //}

            //Console.WriteLine("-----------------------------");

            //foreach (string obj in vect)
            //{
            //    Console.WriteLine(obj);
            //}

            #endregion

            #region 76. Listas (List) - PARTE 1

            //List<string> list = new List<string>();

            //List<string> list2 = new List<string> { "Maria", "Alex" };

            #endregion

            #region 77. Listas (List) - PARTE 2

            //List<string> list = new List<string>();

            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Anna");
            //list.Insert(2, "Marco");


            //foreach (string name in list)
            //    Console.WriteLine(name);

            //Console.WriteLine("List count: " + list.Count);

            //string s1 = list.Find(x => x[0] == 'A');    //objeto x tal que x na posição 0 seja igual a 'A'
            //Console.WriteLine("First name starting with 'A': " + s1);

            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Last name starting with 'A': " + s2);

            //Console.WriteLine();

            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("First name position starting with 'A': " + pos1);

            //int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine("Last name position starting with 'A': " + pos2);

            //Console.WriteLine("---------------------------");
            //Console.WriteLine();

            //List<string> list2 = list.FindAll(x => x.Length == 5);
            //foreach (string name in list2)
            //{
            //    Console.WriteLine(name);
            //}

            //list.Remove("Alex");
            ////list.RemoveAt(3);
            ////list.RemoveRange(2, 2);
            //Console.WriteLine("--------------------------");
            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //list.RemoveAll(x => x[0] == 'M');
            //Console.WriteLine("--------------------------");
            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region 79. Matrizes

            //double[,] mat = new double[2, 3];

            //Console.WriteLine(mat.Length);

            //Console.WriteLine(mat.Rank);

            //Console.WriteLine(mat.GetLength(0));

            //Console.WriteLine(mat.GetLength(1));

            #endregion

            #region 80. Exercício resolvido (matrizes)

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int k = 0; k < mat.GetLength(0); k++)
            {
                Console.Write(mat[k, k] + " ");
            }

            int negativeCount = 0;
            foreach (int num in mat)
            {
                if (num < 0)
                {
                    negativeCount++;
                }
            }


            Console.WriteLine($"\nNegative numbers = {negativeCount}");

            #endregion

        }
    }
}
