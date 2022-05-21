using System;
using System.Globalization;

namespace Calculator_Instance
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circunference(radius);
            double volume = Calculator.Volume(radius);

            Console.WriteLine("Circunference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}