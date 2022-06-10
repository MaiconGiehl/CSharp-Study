using System.IO;

namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Maicon\Desktop\Udemy\CursoCSharp\Working-with-Files\Files-to-Acess\04\file1.txt";
            string targetPath = @"C:\Users\Maicon\Desktop\Udemy\CursoCSharp\Working-with-Files\Files-to-Acess\04\file2.txt";
            
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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