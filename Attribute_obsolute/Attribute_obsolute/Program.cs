using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Attribute_obsolute
{
    public class MyClass
    {
        [Obsolete("Don't use OldMethod, use NewMethod instead", false)]

        static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }
        public static void Main()
        {
            OldMethod();
        }
    }

}
