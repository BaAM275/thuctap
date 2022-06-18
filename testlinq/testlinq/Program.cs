using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using testlinq;

    
namespace testlinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            int[] scores = { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            */
            
            List<sinhvien> students = new List<sinhvien>()
        {
            new sinhvien { First="huy",
                Last="quan",
                ID=111,
                Street="123 to huu",
                Class ="huong duong",
                Scores= new List<int> { 97, 92, 81, 60 } },
            new sinhvien { First="thu",
                Last="uyen",
                ID=112,
                Street="124 to huu",
                Class="hoa hong",
                Scores= new List<int> { 75, 84, 91, 39 } },
            new sinhvien { First="thu",
                Last="linh",
                ID=113,
                Street="125 to huu",
                Class="hoa hong",
                Scores= new List<int> { 88, 94, 65, 91 } },
        };

            // Create the second data source.
            List<lop> lops = new List<lop>()
        {
            new lop { ID=945, type = "thuong", Class="hoa hong" },
            new lop {  ID=956,type = "cao",  Class="huong duong" },
            new lop {  ID=972,type = "thap",  Class="hoa sen" }
        };


            /*
            // Create the query.
            var peopleInSeattle = (from student in students
                                   where student.Class == "hoa hong"
                                   select student.Last)
                        .Concat(from lop in lops
                                where lop.Class == "hoa hong"
                                select lop.type);

           
            // Execute the query.
            foreach (var person in peopleInSeattle)
            {
                Console.WriteLine(person);
            }

            */




            var studentsToXML = new XElement("Root",
           from student in students
           let scores = string.Join(",", student.Scores)
           select new XElement("student",
                      new XElement("First", student.First),
                      new XElement("Last", student.Last),
                      new XElement("Scores", scores)
                   ) // end "student"
               ); // end "Root"

            // Execute the query.
            Console.WriteLine(studentsToXML);


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}

