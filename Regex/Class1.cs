using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexVali
{
    public static class exTion
    {
        //from 9 to 15 numbers
        public static void Sdt(this String a)
        {
            var r = new Regex(@"^[0-9\-\+]{9,15}$");
            if (!r.IsMatch(a))
            {
                Console.WriteLine($"{a} sdt doesn't match");
            }
            else
            {
                Console.WriteLine($"{a} sdt matches");
            }
        }
        //Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character:
        public static void Pass(this String a)
        {
            var r = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            if (!r.IsMatch(a))
            {
                Console.WriteLine($"{a} password doesn't match");
            }
            else
            {
                Console.WriteLine($"{a} password  match");
            }
        }
        public static void email(this String a)
        {
            var r = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            if (!r.IsMatch(a))
            {
                Console.WriteLine($"{a} email doesn't match");
            }
            else
            {
                Console.WriteLine($"{a} email match");
            }
        }
    }
}
