using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections
{
    internal class Arraylist
    {
        static void Main(string[] args)
        {


            var arlist = new ArrayList();
            arlist.Add("Mayur");
            arlist.Add(1);
            arlist.Add(3);
            arlist.Add(true);
            arlist.Add(false);
            arlist.Add(6.5f);

            Console.WriteLine(arlist.Count); // count the arraylist
            Console.WriteLine("Elements of array");
            arlist.Remove(1);  
            arlist.Remove(true);
            arlist.Add(100);




            for (int i = 0; i < arlist.Count; i++)
            {

                Console.WriteLine(arlist[i]);

            }
        }
    }
}
