using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_function
{

	public class Program
    {
        static Func<string,string> operation;
        static Func<int, int,int> operation1;
        static Func<int,int,int> operation2;

        public static string show(string x,string y)
        {
            return x;
            return y;
        }
        public static int show1(int a,int b)
        {
            return a + b;
        }

        public static int show2(int i,int f)
        {
            return i - f;
       
        }

       

        public static void Main(string[] args)
        {
            Func<string,string,string> add = show;
            string result = add("Mayur ","Runwal");
            Console.WriteLine(result);

            Func<int, int,int> sum = show1;
            int res = sum(1, 2);
            Console.WriteLine(res);


           Func<int,int,int>check = show2;
            int ch = check(4,6);
            Console.WriteLine(ch);

        }
    }
    
}
