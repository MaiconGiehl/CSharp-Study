using System;
using System.Globalization;

namespace Exercise
{
    internal class Register
    {
        public int Rent;
        public string Name;
        public string Email;
        public int Room;

        public override string ToString()
        {
            return $"{Room}: {Name}, {Email}";
        }
    }
}
