using System.IO;
using System.Collections.Generic;

namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Maicon\Desktop\Udemy\CursoCSharp\Working-with-Files\Files-to-Acess\05";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        
        }
    }
}