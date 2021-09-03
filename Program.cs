using System;
using System.IO;

namespace FileIoOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to file I/O!");
            // FileExists();
            // ReadAlllines();
            //ReadAllText();
            //FileCopy();
            // DeleteFile();
            Program program = new Program();
           //program. ReadFromStreamReader();
            program.WriteUsingStreamWriter();
        }
        public static void FileExists()
        {
            String path = @"c:\users\admin\source\repos\fileiooperation\TextFile1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
        public static void ReadAlllines()
        {
            string path = @"c:\users\admin\source\repos\fileiooperation\TextFile1.txt";
            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            Console.ReadKey();
        }
        public static void ReadAllText()
        {
            string path = @"c:\users\admin\source\repos\fileiooperation\TextFile1.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

            Console.ReadKey();
        }
        public static void FileCopy()
        {
            string path = @"c:\users\admin\source\repos\fileiooperation\TextFile1.txt";

            string copypath = @"c:\users\admin\source\repos\fileiooperation\TextFile1New.txt";

            File.Copy(path, copypath);
              
             Console.ReadKey();
        }
        public static void DeleteFile()
        {
            string path = @"c:\users\admin\source\repos\fileiooperation\TextFile1.txt";


            File.Delete(path);

            Console.ReadKey();
        }
        public void ReadFromStreamReader()
        {
            String path = @"c:\users\admin\source\repos\fileiooperation\TextFile1.txt";
            using(StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
        public void WriteUsingStreamWriter()
        {
            String path = @"c:\users\admin\source\repos\fileiooperation\TextFile1.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello World - .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadLine();
        }
    }
}
