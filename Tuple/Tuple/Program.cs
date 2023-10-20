using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
      var person = Tuple.Create(1, "Mayur", "Runwal");
      Console.WriteLine(person.Item1);
      Console.WriteLine(person.Item2);
      Console.WriteLine(person.Item3);


            var man = Tuple.Create("one", 2, "three", 4,5,6,7,8);
            Console.WriteLine(man.Item1);
            Console.WriteLine(man.Item2);
            Console.WriteLine(man.Item3); ;
            Console.WriteLine(man.Item4);
            Console.WriteLine(man.Item5);
            Console.WriteLine(man.Item6);
            Console.WriteLine(man.Item7);
            Console.WriteLine(man.Rest); 

            var name = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(9, 10, 11, 12, 14));
            Console.WriteLine(name.Item1);
            Console.WriteLine(name.Rest);

            

           



        }
       
    }
}
