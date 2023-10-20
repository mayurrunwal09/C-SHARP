using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Attribute ///////conditional Attribute...
{
   public class myclass
    {
        [Conditional("DEBUG")]
        public static void message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class test
    {
        static void function1()
        {
            myclass.message("message in function 1");
            function2();
        }
        static void function2()
        {
            myclass.message("message in function 2");
        }
        public static void Main(string[] args)
        {
            myclass.message("message in main");
            function1();
           
        }
    }

}
