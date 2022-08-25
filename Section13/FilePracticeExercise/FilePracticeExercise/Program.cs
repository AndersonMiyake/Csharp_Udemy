using System;
using System.Globalization;
using System.IO;

namespace FilePracticeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            //D:\Documents\Coding projects\DotNet\Csharp_Completo_Udemy\Section13\FilePracticeExercise\FilePracticeExercise\sales\sales.csv
            //string path = @"..\..\..\sales";

            try
            {
                string[] saleInfo = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.CreateText(targetFilePath))
                {
                    foreach (string sale in saleInfo)
                    {
                        string[] itemInfo = sale.Split(',');
                        string name = itemInfo[0];
                        double price = double.Parse(itemInfo[1], CultureInfo.InvariantCulture);
                        int qty = int.Parse(itemInfo[2]);

                        var item = new { Name = name, Price = price, Quantity = qty, Total = price * qty };

                        sw.WriteLine($"{item.Name},{item.Total.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
