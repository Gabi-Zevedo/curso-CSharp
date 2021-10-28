

using AulasAvancadas.Entities.Enums;
using System.Collections.Generic;

namespace AulasAvancadas.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            this.level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                sum += (contract.Date.Year == year && contract.Date.Month == month) ? contract.TotalValue() : 0; // adiciona o valor do contrato caso seja verdade e adiciona nada casos seja mentira
            }
            return sum;
        }


    }
}
