using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{

    public class Math
    {
        public virtual void add(int a,int b,int c)
        {
            
            Console.WriteLine("The addition is "+(a+b+c)); 
        }
      public virtual void show1()
        {
            Console.WriteLine("HELLO");
        }
    }
    public class show : Math
    {
        public override void add(int a, int b, int c)
        {

            Console.WriteLine("The addition is " + (a + b + c));
        }
        public override void show1()
        {
            Console.WriteLine("WORLD");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            

            show s = new show();
            s.add(10,20,30);
            s.show1();


           
          
            
        }
    }
}
