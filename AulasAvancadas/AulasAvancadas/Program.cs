using AulasAvancadas.Entities;
using AulasAvancadas.Entities.Enums;
using System;
using System.Globalization;

namespace AulasAvancadas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Parte usada para as aulas avançadas\n\n");

            Console.Write("Digite o nome do depatamento: ");
            string nomeDpto = Console.ReadLine();
            Console.WriteLine("------ Dados do Funcionário ------");
            Console.Write("Nome: ");
            string nomefuncionario = Console.ReadLine();
            Console.Write("Nivel (Junior/MidLvel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("----------------------------------");

            Department dept = new Department(nomeDpto);
            Worker funcionario = new Worker(nomefuncionario, level, salarioBase, dept);

            Console.Write($"Digite o número de contratos feito por {nomefuncionario}: ");
            int numContratos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numContratos; i++)
            {
                Console.Write($"Digite a data(DD/MM/AAAA) do contrato #{i + 1}: ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write($"Digite o valor pago por hora do contrato #{i + 1}: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"Digite a duração(Horas) do contrato #{i + 1}: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine();
                HourContract contrato = new HourContract(data, horas, valorPorHora);
                funcionario.AddContract(contrato);

            }
            Console.WriteLine("----------------------------------");
            Console.Write("digite o mês e o ano (MM/AAAA) para o calculo dos ganhos: ");
            string dataGanho = Console.ReadLine();
            int mes = int.Parse(dataGanho.Substring(0, 2));
            int ano = int.Parse(dataGanho.Substring(3));

            Console.WriteLine($"\n\nNome: {funcionario.Name}\n");
            Console.WriteLine($"Departamento: {funcionario.Department.Name}\n");
            Console.WriteLine($"Ganho em {dataGanho}: R${funcionario.Income(ano, mes)}");
        }
    }
}
