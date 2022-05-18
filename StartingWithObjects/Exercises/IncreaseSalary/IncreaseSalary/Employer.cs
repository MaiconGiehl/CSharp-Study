using System;
using System.Globalization;

namespace IncreaseSalary
{
    class Employer
    {
        public string Name;
        public double GrossSalary;
        public double Taxes;

        public double NetSalary;

        public void MoreSalary(double moreSalaryPercent)
        {
            NetSalary += NetSalary * (moreSalaryPercent / 100);

        }

        public override string ToString()
        {
            return $"Name = {Name}, Salary = {NetSalary}.";
        }
    }
}
