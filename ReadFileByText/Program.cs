using System;
using System.IO;

namespace ReadFileByText
{
    class Program
    {
        static void Main(string[] args)
        {
            read();
        }
        public static void read()
        {
            string path = "C:/Day27/ReadFileByText/vaibhav.txt";
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
