using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public Double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return ($"Date: {DueDate.ToString("dd/MM/yyyy")} - R$: {Amount.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
