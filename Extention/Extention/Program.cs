using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace Extension_Method{    public static class Ext    {      public static bool check(this int i,int n)
        {
            return i > n;
        }

        static void Main(string[] args)        {

            int i = 109;            bool res = i.check(100);            Console.WriteLine("Result is "+res);        }    }}