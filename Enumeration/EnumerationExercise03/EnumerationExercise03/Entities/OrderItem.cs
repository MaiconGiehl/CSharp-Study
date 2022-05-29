using System;
using System.Globalization;

namespace EnumerationExercise03.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem (Product product, int quantity)        {
            Product = product;
            Quantity = quantity;
            Price = product.Price;
        }
        public double SubTotal ()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product.Name}, " +
                $"${Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantity: {Quantity}, " +
                $"Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
