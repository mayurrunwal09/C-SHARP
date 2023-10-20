using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition
{
    internal class Program
    {
        public class emp
        {
            public int eid { get; set; }
            public string name { get; set; }

            public int age { get; set; }
           

    }
        public class company
        {
            public string name { get; set; }
            public string city { get; set; }

        }
        static void Main(string[] args)
        {

            emp e = new emp();
            e.eid = 101;
            e.name = "Abc";
            e.age = 24;
            Console.WriteLine(e.eid);
            Console.WriteLine(e.name);
            Console.WriteLine(e.age);



            company c = new company();
            c.name = "Triveni";
            c.city = "surat";
            Console.WriteLine(c.name);
            Console.WriteLine(c.city);


          
            
        }
    }
}
