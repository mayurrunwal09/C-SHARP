using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    public abstract class person
    {
        public abstract void field();
        public abstract void info();
        public abstract void add();
        
    }
    public class emp : person
    {
        public override void add()
        {
            Console.WriteLine("The Information is -");
        }

        public override void field()
        {
            int id = 101;
            int c_id = 101;
            
            Console.WriteLine("The person public number is "+id);
            Console.WriteLine("company id is "+c_id);
        }

        public override void info()
        {
            string name = "Mayur";
            long contact = 9923428304;
            Console.WriteLine("this info is " + name);
            Console.WriteLine("contact details "+contact);
            
        }
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            emp e = new emp();
            e.add();
            e.field();
            e.info();

          

        }
    }
}