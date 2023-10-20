using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Dicationary
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> num = new Dictionary<int, string>();
            num.Add(1, "Mayur");
            num.Add(3, "Pratik");
            num.Add(2, "Ram");
            foreach (KeyValuePair<int, string> k in num)
                Console.WriteLine("key {0},value {1}", k.Key, k.Value);

            var location = new Dictionary<string, string>()
            {
                {"Student"," Name,Adrr,ID" } };
            foreach (var l in location)
                Console.WriteLine("key {0},Value{1}", l.Key, l.Value); 

            }
        }
    }

