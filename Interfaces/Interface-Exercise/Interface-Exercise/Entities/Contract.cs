using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Entities
{
    internal class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double Value { get; private set; }
        public List <Installment> Installments { get; private set; }

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
        }
        public Contract(int number, DateTime date, double value, List <Installment> installments) : base (number, date, value)
        {
            Number = number;
            Date = date;
            Value = value;
            Installments = installments;
        }

        public double TotalValue()
        {
            return Number;
        }

        public override string ToString()
        {
            return $"Number: {Number}" +
                $"";
        }
    }
}
