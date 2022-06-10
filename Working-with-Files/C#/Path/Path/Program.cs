using System.IO;

namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Maicon\Desktop\Udemy\CursoCSharp\Working-with-Files\Files-to-Acess\06\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath" + Path.GetTempPath());
        }
    }
}