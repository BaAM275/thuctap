using System;

namespace basic
{
    internal class Program
    {
        public int binhphuong (int a)
        {
            return a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = 32;
            var b = 30;
            int c = a + b;
            Console.WriteLine(c);
            string s = Console.ReadLine();
            string[] words = s.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Contains("huy"));

            qlsv quanlysv = new qlsv();
            quanlysv.NhapSinhVien();
            quanlysv.getListSinhVien();
            quanlysv.ShowSinhVien();
        }
    }
}
