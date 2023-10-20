using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    public class Program
    {
        public class CustomException : Exception
        {
            public CustomException(string per) : base(per)
            {

            }
        }

        static void check(int per)
        {
            if (per > 35)
            {
                throw new CustomException("Pass!!!!!!!!!!!!!!!!");
            }
            Console.WriteLine("Fail");
        }


       
        static void Main(string[] args)
        {
            try
            {
                check(36);
            }
            catch (CustomException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("All the best");
            }


        }
    }
}