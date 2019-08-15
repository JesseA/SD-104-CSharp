using System;
using System.IO;

namespace FileStreaming
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream myFileStream = new FileStream("testfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader myFileReader = new StreamReader(myFileStream);
            while(!myFileReader.EndOfStream)
            {
                Console.WriteLine(myFileReader.ReadLine());
            }
            Console.ReadLine();

        }
    }
}
