using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        
        public List <Installment> ()
        {

        }
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
