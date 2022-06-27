using System.Diagnostics.CodeAnalysis;

namespace Set.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (!(obj is Product))
            {
                return false;
            }

            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}