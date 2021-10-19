using System;
using System.IO;

namespace Stream_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            writer();
        }
        public static void writer()
        {
            string path = @"C:/Day27/Stream_Writer/aher.txt";
            using (StreamWriter sw = File.AppendText(path))
            {

                sw.WriteLine("Hello! How are you?");
                sw.Close();

            }
        }
    }
}
