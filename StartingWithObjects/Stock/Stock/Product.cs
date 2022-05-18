using System;
using System.Globalization;


namespace Stock
{
    internal class Product
    {
        public string Name;
        public double Price;
        public double Amount;

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
