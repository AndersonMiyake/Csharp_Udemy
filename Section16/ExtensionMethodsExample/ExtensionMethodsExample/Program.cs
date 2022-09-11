using System;

namespace ExtensionMethodsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 08, 07, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();
            string s1 = "Good morning dear student!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
