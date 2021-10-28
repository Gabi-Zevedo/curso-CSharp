using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasAvançadas2.Entities
{
    class Comentario
    {
        public string texto { get; set; }

        public Comentario()
        {
        }

        public Comentario(string texto)
        {
            this.texto = texto;
        }
    }

}
