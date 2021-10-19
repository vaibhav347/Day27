using System;
using System.IO;


namespace Stream_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            reader();
        }
        public static void reader()
        {
            string path = "C:/Day27/StreamReader/aher.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}
