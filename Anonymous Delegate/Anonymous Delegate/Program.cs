using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Delegate
{
    internal class Program
    {
        public delegate void print(int val);

        public delegate void show(string str);
        public delegate void show1(double d);
        public delegate void show3(int c);



        static void Main(string[] args)
        {
            print p = delegate (int val)
            {
                Console.WriteLine(val);
            };
            p(1000);


            show s = delegate (string str)
            {
                Console.WriteLine(str);

            };
            s("Hello");


            show1 sw = delegate (double d)
            {
                Console.WriteLine(d);
            };
            sw(16.6);

            show3 ss = delegate (int c)
            {
                Console.WriteLine(c);
            };
            ss(3);
        }
    }
}
