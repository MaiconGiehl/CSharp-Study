using System;
using System.Globalization;

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
            double taxes = 0.0;
            if (EmployeesQnt <= 10)
            {
                taxes = AnualIncome * 16 / 100;
            }
            else if (EmployeesQnt > 10)
            {
                taxes = AnualIncome * 14 / 100;
            }
            return taxes;
        }

        public override string ToString()
        {
            return $"{Name}: ${TotalTaxes().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
