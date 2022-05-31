using System;
using AbstractMethods.Entities.Enums;

namespace AbstractMethods.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
            Color = color;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
