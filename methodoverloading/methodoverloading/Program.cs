using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloading
{

    public class Math
    {
        public void add(int a,int b)
        {
            
            Console.WriteLine(a + b);
        }
        public void add(int a,int b,int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();
            m.add(10,20);
            m.add(10,20,30);    

        }
    }
}
