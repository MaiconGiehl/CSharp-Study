using System;
using System.Globalization;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the dollar exchange rate? ");
            double exchangeRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many dollars do you want to buy? ");
            double dollars = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double value = MoneyConverter.TaxedValue(exchangeRate, dollars);

            Console.WriteLine($"You must pay R${value.ToString("F2", CultureInfo.InvariantCulture)}" +
                $" for yours ${dollars.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
    }
}