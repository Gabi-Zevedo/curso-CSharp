using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace RevisaoStatic
{
    class Conversao
    {
        public static double ValorDolar = 3.10;
        public static double ValorIof = 1.06;
        public static string Dolar(double quantidade)
        {
            string _valorConvertido = ($"O valor a ser pago para comprar ${quantidade.ToString("F2", CultureInfo.InvariantCulture)} é de R$:{((quantidade * ValorIof) * ValorDolar).ToString("F2", CultureInfo.InvariantCulture)}".ToString(CultureInfo.InvariantCulture ));

            return _valorConvertido;
        }
    }
}
