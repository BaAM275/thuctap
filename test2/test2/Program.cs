using System;
using System.IO;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string filename = "abc.txt";
            string content = File.ReadAllText(filename);
            Console.WriteLine(content);   
         }
    }
}
