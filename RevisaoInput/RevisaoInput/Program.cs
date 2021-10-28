using System;
using System.Globalization;
namespace RevisaoInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome completo");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o preço do produto");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu último nome, idade e altura (mesma linha)");
            string[] info = Console.ReadLine().Split(' ');
            string infoNome = info[0];
            int infoIdade = int.Parse(info[1]);
            double infoAltura = double.Parse(info[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoProduto.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(infoNome);
            Console.WriteLine(infoIdade);
            Console.WriteLine(infoAltura.ToString(CultureInfo.InvariantCulture));

        }
    }
}
