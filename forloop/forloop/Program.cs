using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // for loop
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }
            

            
               // while loop
            int j = 0;
            while (j < 20)
            {
                Console.WriteLine("value of j is {0} ", j);
                j++;
            } 
            

            // do while loop
            int m = 0;
            do
            {
                Console.WriteLine(m);
                m++;
            }
            while (m <= 20);

        }
    }
}
