using System;
using System.Globalization;

namespace Exercise.Entities
{
    internal class ImportedProduct : Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double CustomsFee { get; set; }
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double fee)
            : base (name, price)
        {
            Name = name;
            Price = price;
            CustomsFee = fee;
        }

        public double TotalPrice ()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} " +
                $"${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Customs fee: ${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
