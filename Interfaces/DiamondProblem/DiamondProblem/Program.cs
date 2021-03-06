using System;
using Interface.Devices;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice cDevice = new ComboDevice() { SerialNumber = 3921 };
            cDevice.ProcessDoc("My dissertation");
            cDevice.Print("My dissertation");
            Console.WriteLine(cDevice.Scan());

        }
    }
}