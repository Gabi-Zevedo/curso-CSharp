using System;
using System.IO;

namespace RevisaoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Gabriel\C#\RevisaoArquivos\arquivos.txt";
          
          
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("TESTEEEEEEEEEEEE");
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
                
            }
            catch(IOException e)
            {
                Console.WriteLine("ERRO:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
