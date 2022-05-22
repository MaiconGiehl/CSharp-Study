using System;
using System.Globalization;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref
            int x = 10;
            Calculator.TripleWithRef(ref x);
            Console.WriteLine(x);

            // out
            int y = 10;
            int triple;
            Calculator.TripleWithOut(y, out triple);
            Console.WriteLine(triple);

            // OBS: esses modificadores são considerados "código ruim"

        }
    }
}
