using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoArquivos.Entities
{
    class Log
    {
        public string Usuario { get; set; }
        public DateTime Data { get; set; }

        public Log(string usuario, DateTime data)
        {
            Usuario = usuario;
            Data = data;
        }

        public override int GetHashCode()
        {
            return Usuario.GetHashCode() + Data.Day;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Log))
            {
                return false;
            }
            Log other = obj as Log;
            return Usuario.Equals(other.Usuario);
        }
    }
}
