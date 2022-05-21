using System;
using System.Globalization;

namespace Converter
{
    class MoneyConverter
    {

        public static double IoF = 1.1;
        static public double TaxedValue(double Dollars, double ExchangeRate)
        {
            double finalValue = Dollars * ExchangeRate;
            return finalValue + finalValue * IoF / 100.0;
        }
       
    }
}
