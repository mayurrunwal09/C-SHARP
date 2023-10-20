using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            Console.WriteLine("the total enqueue:" + q.Count);


            foreach (var u in q)
                Console.WriteLine(u);

            Queue<string> s = new Queue<string>();
            s.Enqueue("hello");
            s.Enqueue("dushd");

            Console.WriteLine(s.Count);

            while(s.Count > 0)
            {
                Console.WriteLine(s.Dequeue());
                Console.WriteLine(s.Count);
            }

           

        }    
    }
}
