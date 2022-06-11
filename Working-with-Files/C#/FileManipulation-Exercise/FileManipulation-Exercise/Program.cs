using System;
using System.Globalization;
using System.IO;
using FileManipulation_Exercise.Entities;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the file path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = @$"{sourceFolderPath}\Out";
                string targetFilePath = @$"{targetFolderPath}\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] properties = line.Split(',');

                        string name = properties[0];
                        double price = double.Parse(properties[1], CultureInfo.InvariantCulture);
                        int qty = int.Parse(properties[2]);
                        Product product = new Product(name, price, qty);

                        sw.WriteLine(product);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}