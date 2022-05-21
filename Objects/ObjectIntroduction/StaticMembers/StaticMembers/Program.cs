using System;
using System.Globalization;

namespace StaticMembers
{
    class Program
    {

    static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Enter the radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunference(radius);
            double volume = Volume(radius);

            Console.WriteLine("Circunference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunference(double r)
        {
            return 2 * Pi * r;
        }

        static double Volume (double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}