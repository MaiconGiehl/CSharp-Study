using System;
using System.Globalization;

namespace Params
{
    internal class Calculator
    {
        public static void TripleWithRef(ref int a)
        {
            a = a * 3;
        }

        public static void TripleWithOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
