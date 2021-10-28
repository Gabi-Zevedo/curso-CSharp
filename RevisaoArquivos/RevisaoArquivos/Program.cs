using RevisaoArquivos.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace RevisaoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Gabriel\C#\RevisaoArquivos\arquivos.txt";
            HashSet<Log> set = new HashSet<Log>();
            
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string nome = line[0];
                        DateTime data = DateTime.Parse(line[1]);
                        set.Add(new Log(nome,data));
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
