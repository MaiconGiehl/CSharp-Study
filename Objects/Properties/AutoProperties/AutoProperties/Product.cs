using System;
using System.Globalization;


namespace AutoProperties
{
    class Product
    {
        private string _name; // Privado pois sofre manipulacao
        public double Price { get; private set; }
        public int Amount { get; private set; }

        //prop tab tab

        public Product()
        {
        }

        public Product(string name, double price, int amount)
        {
            _name = name;
            Price = price;
            Amount = amount;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
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
            return _name
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