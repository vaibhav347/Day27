using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileExistsORNot
{
    public class UseCase1
    {
        public void fileExists()
        {
            string path = "C:/Day27/FileExistsORNot/vaibhav.txt";
            if (File.Exists(path))
                Console.WriteLine("File is exists");
            else
                Console.WriteLine("File not exists");

        }
    }
}
