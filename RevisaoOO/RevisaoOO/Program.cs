using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevisaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> lista = new List<Carro>();
            while (true)
            {
                Console.WriteLine("'A' para adicionar\n'E' para exibir\n'S' para sair ");
                char opc = char.Parse(Console.ReadLine());

                if (Char.ToLower(opc) == 's') // quebra a repetição
                {
                    break;
                }
                else if (Char.ToLower(opc) == 'a') //adicona novo carro
                {
                    Carro carro = new Carro();

                    Console.WriteLine("Digite o seguinte (qtd portas,marca,modelo,cor,ano)");
                    string[] dados = Console.ReadLine().Split(',');
                    carro.QtdPortas = int.Parse(dados[0]);
                    carro.Marca = dados[1];
                    carro.Modelo = dados[2];
                    carro.Cor = dados[3];
                    carro.Ano = dados[4];
                    Console.WriteLine(carro.QtdPortas.GetTypeCode());
                    lista.Add(carro);
                    continue;
                }
                else if (Char.ToLower(opc) == 'e') //exibir lista
                {
                    if (!lista.Any())
                    {
                        Console.WriteLine("\nLISTA VAZIA!!\n");
                        continue;
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Console.WriteLine($"\nCarro {i + 1}: {lista[i]} \n");
                    }
                }
                else // entrada invalida
                {
                    Console.WriteLine("Entrada inválida");
                    continue;
                }
            }
        }
    }
}
