using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FileManipulation_Exercise.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Product(string name, double price, int qty)
        {
            Name = name;
            Price = price;
            Qty = qty;
        }

        public double TotalPrice ()
        {
            return Price * Qty;
        }

        public override string ToString()
        {
            return $"{Name},{TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
