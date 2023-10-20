using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_delegate
{
    internal class Program
    {
       public delegate void Print(int val);
       
        static void ConsolePrint(int i)
       {
           Console.WriteLine(i);
       }


        public delegate void show(string message);
        static void Mine(string message)
        {
            Console.WriteLine("Hello "+message);

        }

        static void Main(string[] args)
        {



           Print prnt = ConsolePrint;
           prnt(10);

            show s = Mine;
            s("Mayur");
        }

        
        


    }
}
