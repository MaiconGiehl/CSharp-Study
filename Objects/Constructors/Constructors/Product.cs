using System;
using System.Globalization;


namespace Constructors
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Amount;

        public Product()
        {
            Amount = 0;
        }

        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, int amount) : this(name, price)
        {
            Amount = amount;
        }

        public double TotalInStock()
        {
            return Price * Amount;
        }

        public void AdcProducts(int moreProducts)
        {
            Amount += moreProducts;
        }

        public void RmvProducts(int lessProducts)
        {
            Amount -= lessProducts;
        }

        public override string ToString()
        {
            return Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Amount
                + " units, Total: $"
                + TotalInStock().ToString("F2", CultureInfo.InvariantCulture)
                + ".";
        }
    }
}