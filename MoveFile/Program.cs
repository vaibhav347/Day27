using System;
using System.IO;
namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            moveFile();
        }
        public static void moveFile()
        {
            string source_File = "C:/Day27/MoveFile/vaibhav.txt";
            string dest_File = "C:/Day27/MoveFile/aher.txt";
            File.Move(source_File, dest_File);
        }
    }
}
