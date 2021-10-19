using System;
using System.IO;

namespace ReadFileByAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            read();
        }
        public static void read()
        {
            string path = "C:/Day27/ReadFileByAllLines/vaibhav.txt";
            string[] line;
            line = File.ReadAllLines(path);
            Console.WriteLine(line[0]);

        }
    }
}
