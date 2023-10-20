using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class Ternary
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 14;
            int c = 15;

            var sum = a > b  ? "a is greater" + a : "b is greater " + b ;
            Console.WriteLine(sum);

            //Nested Ternary
            var sum1 = a > b ? a > c ? "a is greater " + a : "c is gretter " + c :
                        b > a ? b > c ? "b is greater " + b : "c is greter " + c : "All are equal " + a;
            Console.WriteLine(sum1);
        }
    }
}
