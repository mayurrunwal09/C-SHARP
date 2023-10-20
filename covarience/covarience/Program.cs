using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covarience
{
    class A { }
    class B : A { }
    public class C { }
    public class D : C { }
    internal class Program
    {
        delegate A mydelegate();
        delegate C mydelegate1();
        static void Main(string[] args)
        {
            mydelegate del = Add;
                del();

            mydelegate del1 = sub;
            del1();

            mydelegate1 del2 = mul;
            del2();

            mydelegate1 del3 = div;
        }
        static A Add()
        {
            Console.WriteLine("This is Addition");
            return new A();
        }
        static B sub()
        {
            Console.WriteLine("This Is sub");
            return new B();
        }
        static C mul()
        {
            
            
            Console.WriteLine("this is mul");
            return new C();
        }
        static D div()
        {
            Console.WriteLine("this is div");
            return new D();
        }
    }
}
