using GetHashCodeAndEqualsExamples.Entities;
using System;

namespace GetHashCodeAndEqualsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = "Maria";
            //string b = "Maria";

            //Console.WriteLine(a.Equals(b));

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);  // Diferentes na referência de memória
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
