using System;
using System.IO;
namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            copyFile();
        }
        public static void copyFile()
        {
            string source_File = "C:/Day27/CopyFile/vaibhav.txt";
            string dest_File = "C:/Day27/CopyFile/aher.txt";
            File.Copy(source_File, dest_File);
        }
    }
}
