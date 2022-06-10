using System.IO;


namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Maicon\Desktop\Udemy\CursoCSharp\Working-with-Files\Files-to-Acess\03\file1.txt";

            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    //using (StreamReader sr = new StreamReader(fs))
                    using (StreamReader sr = File.OpenText(path)) // Simpler
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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