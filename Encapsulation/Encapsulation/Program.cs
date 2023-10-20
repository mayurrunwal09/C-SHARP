using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {

       
       
          private string Ename;
          private int Eage;
          private long contact;
        

        
        public string Ename1
        {
            get { return Ename; }
            set { Ename = value; }

           
        }
      
        public int Eage1
        {
            set { Eage = value; }
            get { return Eage; }
        }

       
        public long Contact1
        {
            set { contact = value; }
            get { return contact; }
        }
      
        public static void Main(string[] args) 
        {
            Program p = new Program();
            p.Ename = "MAYUR";
            p.Eage = 24;
            p.Contact1 = 9923428304;
          
            Console.WriteLine(p.Ename);
            Console.WriteLine(p.Eage);
            Console.WriteLine(p.contact);
   
        }
    }

}