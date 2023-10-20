using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    
        public class emp
        {
            public int empid { get; set; }
            public string name { get; set; }
            public int age { get; set; }
        }
        public class empfield
        {
            public emp Get(string name)
            {
                return new emp();
            }
            public bool checks(emp e)
        {
            Console.WriteLine("emp saved");
            return true;    

        }
        public bool valid(emp e)
        {
            Console.WriteLine("emp not exist");
            return false;   
        }
            static void Main(string[] args)
             {
                emp em = new emp();
                em.empid = 1;
                em.name = "Mayur";
            em.age = 24;

                Console.WriteLine(em.empid);
                Console.WriteLine(em.name);
            Console.WriteLine(em.age);


             }
        }
    
}
