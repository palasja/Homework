using System;
using System.IO;

namespace Task9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Test.txt";
            string path = @"D:\Task9_3";
            try 
            {
                FileInfo file = new FileInfo($@"{path}\{fileName}");
                file.Create();
            }
            catch(DirectoryNotFoundException ex)
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"{path} was createdd");
            }
        }
    }
}
