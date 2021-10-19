using System;
using System.IO;
namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void moveFile()
        {
            string path = "C:/Day27/MoveFile/vaibhav.txt";
            File.Delete(path);
        }

    }
}
