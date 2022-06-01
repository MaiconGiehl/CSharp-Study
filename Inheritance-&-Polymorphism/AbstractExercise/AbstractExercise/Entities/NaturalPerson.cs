using System;
using System.Globalization;

namespace AbstractExercise.Entities
{
    internal class NaturalPerson : TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public double HealthExpen { get; set; }
        public NaturalPerson(string name, double anualIncome, double healthExpen)
            : base (name, anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
            HealthExpen = healthExpen;
        }

        public override double TotalTaxes()
        {
            double taxes = 1.0;
            if (AnualIncome < 20000.00)
            {
                taxes = AnualIncome * (AnualIncome / 15 * 100);
                if (HealthExpen < 0)
                {
                    taxes -= HealthExpen * (HealthExpen / 50 * 100);
                }
            }
            else if (AnualIncome >= 200000.00 )
            {
                taxes = AnualIncome * (AnualIncome * 25 / 100);
                if (HealthExpen < 0)
                {
                    taxes -= HealthExpen * (HealthExpen * 50 / 100);
                }
            }
            return taxes;
        }

        public override string ToString()
        {
            return $"{Name}: ${TotalTaxes().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
