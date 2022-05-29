using System;

namespace EnumerationExercise03.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double SubTotal ()
        {
            return Price * Quantity;
        }

    }
}
