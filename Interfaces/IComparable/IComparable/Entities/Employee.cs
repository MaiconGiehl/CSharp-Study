﻿using System;
using System.Globalization;

namespace Comparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee (string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not a employee");
            }
            Employee other = obj as Employee;

            //return Name.CompareTo(other.Name); Compare by name;

            return Salary.CompareTo(other.Salary); // Compare by salary;

        }
    }
}
