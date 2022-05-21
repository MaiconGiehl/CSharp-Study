using System;
using System.Globalization;

namespace Rectangle
{
    class RectangleClass
    {
        public double Width;
        public double Height;
        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }
    }
}
