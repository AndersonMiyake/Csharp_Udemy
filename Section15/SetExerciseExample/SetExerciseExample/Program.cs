using System;
using System.Collections.Generic;
using System.IO;
using SetExerciseExample.Entities;

namespace SetExerciseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input file
            //amanda 2020 - 08 - 26T20: 45:08
            //alex86 2020 - 08 - 26T21: 49:37
            //bobbrown 2020 - 08 - 27T03: 19:13
            //amanda 2020 - 08 - 27T08: 11:00
            //jeniffer3 2020 - 08 - 27T09: 19:24
            //alex86 2020 - 08 - 27T22: 39:52
            //amanda 2020 - 08 - 28T07: 42:19

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }
                }
                Console.WriteLine("Total users: " + set.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
