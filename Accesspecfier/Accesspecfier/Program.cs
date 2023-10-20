using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesspecfier
{
    internal class Program
    {
        public class Animal
        {
            public string name;
            public Animal(string name)
            {
                this.name = name;
            }
            public void makesount()
            {
                Console.WriteLine($ "{name} make some sound: ");
            }

            class dog : Animal
            {

            }
        }
        }
        static void Main(string[] args)
        {
           
        }
    }
}
