using AulasAvançadas2.Entities;
using System;

namespace AulasAvançadas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOVO POST");
            Post post = new Post(DateTime.Now, "SHAZAM", "Vendo um SHAZAM com os parça", 3);
            while (true)
            {
                Console.Write("1 - novo comentario\t 2 - sair: ");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.Write("Escreva o comentário... ");
                    Comentario comentario = new Comentario(Console.ReadLine());
                    post.AdicionarComentario(comentario);
                }
                else if (opc == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Comando Inválido\n");
                }

            }
            Console.WriteLine(post);
            
        }
    }
}
