using System;
using System.Globalization;


namespace Properties
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _amount;

        public Product(string name, double price, int amount)
        {
            _name = name;
            _price = price;
            _amount = amount;
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

        public double Price { get { return _price; } }

        public int Amount { get { return _amount; } }
        
        public double TotalInStock()
        {
            return _price * _amount;
        }

        public void AdcProducts(int moreProducts)
        {
            _amount += moreProducts;
        }

        public void RmvProducts(int lessProducts)
        {
            _amount -= lessProducts;
        }

        public override string ToString()
        {
            return _name
                + ", $"
                + _price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _amount
                + " units, Total: $"
                + TotalInStock().ToString("F2", CultureInfo.InvariantCulture)
                + ".";
        }
    }
}