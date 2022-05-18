using System;
using System.Globalization;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangleClass rectan = new RectangleClass();

            Console.WriteLine("Enter rectangle's width and height: ");
            rectan.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectan.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Area = " + rectan.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter = " + rectan.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + rectan.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}