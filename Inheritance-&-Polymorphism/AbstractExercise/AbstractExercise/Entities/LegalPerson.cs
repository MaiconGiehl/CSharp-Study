using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise.Entities
{
    internal class LegalPerson : TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public int EmployeesQnt { get; set; }

        public LegalPerson(string name, double anualIncome, int employeesQnt)
            : base (name, anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
            EmployeesQnt = employeesQnt;
        }

        public override double TotalTaxes ()
        {
            return 3;
        }
    }
}
