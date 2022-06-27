using System;
using System.Globalization;
using System.Collections.Generic;
using inheritance_practice_exercise.Entities;

namespace inheritance_practice_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make a program to read the data of N
            //products(N provided by the user).At the end,
            //show the price tag of each product in the same 
            //order as they were typed.
            //Every product has a name and a price. Imported
            //products have a customs fee, and used products
            //have a manufacturing date.
            //This specific data must be
            //added to the price tag as per the
            //example(next page).For 
            //imported products, the customs and excise must be
            //added to the final price of the product.

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char prodType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (prodType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (prodType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
