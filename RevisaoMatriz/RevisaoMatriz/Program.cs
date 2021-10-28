using System;

namespace RevisaoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            for (int x = 0; x<matriz.GetLength(0); x++)//leitura da matriz
            {
                for (int y = 0; y<matriz.GetLength(1); y++)
                {
                    Console.Write($"Digite a posição {x+1}.{y+1}: ");
                    matriz[x, y] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            for (int x = 0; x < matriz.GetLength(0); x++)//exibição da matriz
            {
                Console.Write("|");
                for (int y = 0; y < matriz.GetLength(1); y++)
                {   
                    if (y == (matriz.GetLength(1) - 1))
                    {
                        Console.Write(matriz[x, y]);
                    }
                    else
                    {
                    Console.Write($"{matriz[x,y]}\t");
                    }
                }
                Console.WriteLine("|");
            }
        }
    }
}
