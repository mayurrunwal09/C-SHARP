using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Delegate
{
    internal class Program
    {
        public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        public static bool even(int i)
        {

            return i % 2 == 0;
        }   
            
         public static bool Test(int j)
        {
            return j > 35;
        }
        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("HELLO WORLD");
            Console.WriteLine(result);


            Predicate<int> check = even;
            bool output = check(6);
            Console.WriteLine("is the given number is even...?"+output);

            Predicate<int> Check1 = Test;
            bool ch = Check1(5);
            Console.WriteLine("the result is "+ch);
        }
    }
}
