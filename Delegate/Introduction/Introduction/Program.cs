using System;
using Delegate.Services;

namespace Delegate
{

    delegate double BinaryNumericOperation(double n1, double n2);


    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum); // same thing with more words
            BinaryNumericOperation op = CalculationService.Sum;

            //double result = op.Invoke(a, b); // same thing with more words
            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}