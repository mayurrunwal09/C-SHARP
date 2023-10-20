using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Program
    {
        private class Person
        {
           public string Name { get; set; }
            public string lastname { get; set; }

            public string getname()
            {
                return Name + "" + lastname;
            }
        }
        class emp : Person
        {
            public int Empid { get; set; }
            public string Compname { get; set; }
        }
        class emp1 : emp
        {
            public long contact { get; set; }

        }

        public static void Main(string[] args)
        {
            emp e = new emp();
            e.Name = "Mayur";
            e.lastname = "Runwal";
            e.Empid = 101;
            e.Compname = "Triveni";
            Console.WriteLine("The name is " + e.Name);
            Console.WriteLine("Last name is "+e.lastname);
            Console.WriteLine("The id of emp is " + e.Empid);
            Console.WriteLine("The name of company is " + e.Compname);

            emp1 e1 = new emp1();
            e1.contact = 9923428304;
            Console.WriteLine(e1.contact);

        }
    }
}

