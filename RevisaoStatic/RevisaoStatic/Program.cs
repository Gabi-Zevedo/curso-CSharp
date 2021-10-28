using System;
using System.Globalization;
namespace RevisaoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"O dolar está R${Conversao.ValorDolar.ToString("F2",CultureInfo.InvariantCulture)}, qual a quantidade que você deseja comprar?");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"{Conversao.Dolar(quantidade)}");
        }
    }
}
