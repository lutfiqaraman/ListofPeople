using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewList
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Info info = new Info();
            info.PrintHeader();

            ListofPeople listofpeople = new ListofPeople();
            listofpeople.PrintList();

            Console.WriteLine();
            info.PrintFooter();

            Console.ReadLine();

        }

        class People
        {
            public string   Name { get; set; }
            public int      Age { get; set; }
            public string   Country { get; set; }

            public People (string name, int age, string country)
            {
                Name    = name;
                Age     = age;
                Country = country;
            }

        }

        class ListofPeople
        {
            
            List<People> PeopleList = new List<People>
            {
                new People("Adam", 25, "UK"),
                new People("David", 30, "US"),
                new People("Lara", 32, "NZ"),
                new People("Sara", 33, "AUS")
            };

            public void PrintList()
            {
                var i = 1;
                foreach (var person in PeopleList)
                    Console.WriteLine("{0} \t {1} \t {2} \t {3}", i++, person.Name, person.Age, person.Country);
            }
            
        }

        public class Info
        {
            public void PrintHeader()
            {
                Console.WriteLine("ID \t Name \t Age \t Country");
                Console.WriteLine("=============================");
            }

            public void PrintFooter()
            {
                Console.WriteLine("Done ...");
            }
        }

    }
}
