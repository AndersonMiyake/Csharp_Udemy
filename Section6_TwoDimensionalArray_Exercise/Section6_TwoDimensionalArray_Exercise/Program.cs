using System;

namespace Section6_TwoDimensionalArray_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a program to read two integers M and N, and then read
            //a matrix of M rows by N columns containing integers,
            //there may be repetitions.Then, read an integer X that
            //belongs to the matrix.For each occurrence of X, show the values to the
            //above, to the right, and below X, if any, as in the example.

            string[] size = Console.ReadLine().Split(' ');
            int row = int.Parse(size[0]);
            int col = int.Parse(size[1]);

            int[,] array = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < col; j++)
                {
                    array[i, j] = int.Parse(values[j]);
                }
            }


            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    if (array[i, j] == num)
                    {
                        Console.WriteLine("\nPosition {0},{1}:", i, j);

                        //Up
                        if (i > 0)
                            Console.WriteLine("Up: " + array[i - 1, j]);

                        //Right
                        if (j < col - 1)
                            Console.WriteLine("Right: " + array[i, j + 1]);

                        //Down
                        if (i < row - 1)
                            Console.WriteLine("Down: " + array[i + 1, j]);

                        //Left
                        if (j > 0)
                            Console.WriteLine("Left: " + array[i, j - 1]);


                        ////Left
                        //if (j > 0)
                        //    Console.WriteLine("Left: " + array[i, j - 1]);

                        ////Up
                        //if (i > 0)
                        //    Console.WriteLine("Up: " + array[i - 1, j]);

                        ////Right
                        //if (j < col - 1)
                        //    Console.WriteLine("Right: " + array[i, j + 1]);

                        ////Down
                        //if (i < row - 1)
                        //    Console.WriteLine("Down: " + array[i + 1, j]);


                    }
                }


        }
    }
}
