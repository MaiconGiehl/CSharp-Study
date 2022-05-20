using System;
using System.Globalization;


namespace Constructors
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Amount;

        // Construcao padrao
        public Product() { }
        
        public Product(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Amount = 5;
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