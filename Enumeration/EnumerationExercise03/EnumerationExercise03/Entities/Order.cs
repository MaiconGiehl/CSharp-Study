using System;
using EnumerationExercise03.Entities.Enums;

namespace EnumerationExercise03.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
