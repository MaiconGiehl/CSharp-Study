using System;
using System.IO;
using System.Collections.Generic;
using Comparable.Entities;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Maicon\Desktop\Udemy\CursoCSharp\Interfaces\IComparablePath\Something.txt";
            string path = @"C:\Users\Maicon\Desktop\Udemy\CursoCSharp\Interfaces\IComparablePath\SomethingbutCSV.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}