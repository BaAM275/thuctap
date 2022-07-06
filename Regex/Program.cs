using RegexVali;
using System;
using System.Text.RegularExpressions;

namespace Regexvali
{
    class Program

    {
        public static void Main(string[] args)
        {
            var cc1 = "089754466";
            var test = "mysite@ourearth.com";
            test.email();
            cc1.Sdt();

            string vali = null;
            vali = Console.ReadLine();
            vali.Pass();
            vali.email();
            vali.Sdt();
        }
    }
}
