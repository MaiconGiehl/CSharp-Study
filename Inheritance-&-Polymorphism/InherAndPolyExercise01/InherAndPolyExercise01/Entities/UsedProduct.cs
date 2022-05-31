using System;
using System.Globalization;

namespace Exercise.Entities
{
    internal class UsedProduct : Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base (name, price)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) " +
                $"${Price.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
