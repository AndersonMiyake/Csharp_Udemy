using System;
using System.Collections.Generic;
using System.IO;
using InterfaceIComparableExample.Entities;

namespace InterfaceIComparableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string path = @"d:\temp\in.txt";
            //    try
            //    {
            //        using (StreamReader sr = File.OpenText(path))
            //        {
            //            List<string> list = new List<string>();
            //            while (!sr.EndOfStream)
            //            {
            //                list.Add(sr.ReadLine());
            //            }
            //            list.Sort();
            //            foreach (string str in list)
            //            {
            //                Console.WriteLine(str);
            //            }
            //        }
            //    }
            //    catch (IOException e)
            //    {
            //        Console.WriteLine("An error occurred");
            //        Console.WriteLine(e.Message);
            //    }

            string path = @"d:\temp\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
