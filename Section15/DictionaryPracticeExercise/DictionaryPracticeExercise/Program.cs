using System;
using System.Collections.Generic;
using System.IO;

namespace DictionaryPracticeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Na contagem de votos de uma eleição, são gerados vários registrosde votação contendo o nome do candidato e a quantidade de votos(formato.csv) que ele obteve em uma urna de votação. Você devefazer um programa para ler os registros de votação a partir de umarquivo, e daí gerar um relatório consolidado com os totais de cadacandidato.

            //input file example
            //Alex Blue,15
            //Maria Green,22
            //Bob Brown,21
            //Alex Blue,30
            //Bob Brown,15
            //Maria Green,27
            //Maria Green,22
            //Bob Brown,25
            //Alex Blue,31

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> votesDict = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int numVotes = int.Parse(line[1]);

                        if (!votesDict.ContainsKey(candidate))
                        {
                            votesDict[candidate] = numVotes;
                        }
                        else
                        {
                            votesDict[candidate] += numVotes;
                        }
                    }
                }

                foreach (KeyValuePair<string, int> item in votesDict)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
