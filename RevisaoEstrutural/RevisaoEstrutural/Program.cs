using System;

namespace RevisaoEstrutural
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rodando = true;
            while (rodando)
            {
                var hora = double.Parse(DateTime.Now.ToString("HH"));
                Console.WriteLine("Digte seu nome: ");
                string nome = Console.ReadLine();
                int n1 = 1;
                if (nome.Equals("sair", StringComparison.OrdinalIgnoreCase))
                {
                    rodando = false;
                    Console.WriteLine("Saindo...");
                }
                else
                {
                for (int i = 0; i<3; i++)
                {
                    n1 *= int.Parse(Console.ReadLine());
                    //n1 *= valor;
                }
                    string saudacao = TipoSaudacao(hora);
                    Console.WriteLine($"\n{saudacao}, {nome}, AQUI TEM FOR BIIIIIIIIIIIIIIIIIRL {n1}\n");
                }
            }
        }

        static string TipoSaudacao(double hora)
        {

            if (hora < 12)
            {
                return ("Bom Dia");
            }
            else if (hora < 18)
            {
                return ("Boa Tarde");
            }
            else
            {
                return ("Boa Noite");
            }
        }
    }
}
