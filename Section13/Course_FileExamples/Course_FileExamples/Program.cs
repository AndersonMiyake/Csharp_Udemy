using System;
using System.IO;
using System.Collections.Generic;

namespace Course_FileExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 195. File, FileInfo e IOException
            ////string sourcePath = "d:\\temp\\file1.txt";
            //string sourcePath = @"d:\temp\file1.txt";
            //string targetPath = @"d:\temp\file2.txt";


            //try
            //{
            //    FileInfo fileInfo = new FileInfo(sourcePath);
            //    fileInfo.CopyTo(targetPath);

            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region 196. FileStream e StreamReader

            //string path = @"d:\temp\file1.txt";
            ////FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    //fs = new FileStream(path, FileMode.Open);
            //    //sr = new StreamReader(fs);
            //    sr = File.OpenText(path);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //    //if (fs != null) fs.Close();
            //}

            #endregion

            #region 197. Bloco using 

            //string path = @"d:\temp\file1.txt";

            //try
            //{
            //    //using (FileStream fs = new FileStream(path, FileMode.Open))
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region 198. StreamWriter

            //string sourcePath = @"d:\temp\file1.txt";
            //string targetPath = @"d:\temp\file2.txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);

            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach (string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region 199. Directory, DirectoryInfo

            //string path = @"d:\temp\myfolder";

            //try
            //{
            //    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS:");
            //    foreach (string s in folders)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FILES:");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    //Directory.CreateDirectory(path + "\\newfolder");
            //    Directory.CreateDirectory(path + @"\newfolder");
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region 200. Path

            string path = @"d:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());


            #endregion
        }
    }
}
