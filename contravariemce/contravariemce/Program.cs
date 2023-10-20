using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contravariemce
{
   
    public class Small
    {

    }
    public class Big : Small
    {

    }
    public class Bigger : Big
    {

    }
    public delegate Small covarDel(Big mc);
    internal class Program
    {
        
       public static Big Add(Big bg)
        {
            Console.WriteLine("This is Addition");
            return new Big();
        }
        public static Small Sub(Big bg)
        {
            Console.WriteLine("This is substraction");
            return new Small();
        }
       
        public static void Main(string[] args)
        {
            covarDel del = Add;

            Small sm = del(new Big());

            del = Sub;
            Small sm1 = del (new Big());

           

       }




    }

}
