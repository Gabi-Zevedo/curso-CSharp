using DesafioInterface.Entities;
using DesafioInterface.Services;
using System;
using System.Globalization;

namespace DesafioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("------Contract Info------");
            Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Installments Numbers: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(DateTime.Now, contractNumber, contractValue);

            ContractService contractService = new ContractService(new PayPalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("\nInstallments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
