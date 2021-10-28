using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasAvançadas2.Entities
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo  { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AdicionarComentario (Comentario c)
        {
            Comentarios.Add(c);
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"{Titulo}\n" +
                $"{Likes} likes - {Momento}\n" +
                $"{Conteudo}\n");
            s.AppendLine("Comentarios:\n");
            foreach (Comentario comentario in Comentarios)
            {
                s.AppendLine(comentario.texto + "\n");
                
            }
            return s.ToString();
        }
    }

}
