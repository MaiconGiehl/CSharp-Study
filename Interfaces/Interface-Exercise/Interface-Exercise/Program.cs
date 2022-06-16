using System;
using System.Globalization;
using Exercise.Entities;
using System.Collections.Generic;


namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter nuber of installments: ");
            int n = int.Parse(Console.ReadLine());


            List<Installment> installment;

            Contract contract = new Contract(number, date, value);

            for(int m = 1; m < installments.Count; m++)
            {

            }

            foreach (Installment installment in installments)
            {

            }


        }
    }
}
 