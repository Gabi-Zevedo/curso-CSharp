using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasAvancadas.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public HourContract() { }

        public HourContract(DateTime date, int hours, double valuePerHour)
        {
            Date = date;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
