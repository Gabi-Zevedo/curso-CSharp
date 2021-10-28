using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoOO
{
    class Carro
    {
        private int _qtdPortas;
        private string marca;
        private string modelo;
        private string cor;
        private string ano;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Ano { get => ano; set => ano = value; }
        public int QtdPortas
        {
            get { return _qtdPortas; }
            set
            {
                if (!value.GetTypeCode().Equals("Int32") && value > 0)
                {
                    _qtdPortas = value;
                }

            }
            }

        public Carro()
        {

        }

        public Carro(int qtdPortas, string marca, string modelo, string cor, string ano)
        {
            QtdPortas = qtdPortas;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }

        public override string ToString()
        {
            return ($"{Marca} {Modelo} {Cor} {QtdPortas} Portas ano {Ano}");
        }
    }
}
