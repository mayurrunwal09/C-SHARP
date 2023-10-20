using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }

        public void login()
        {
            Console.WriteLine("you are login");
        }
        public virtual void confirm()
        {
            Console.WriteLine("Welcome");
        }
    }

    class school : student
    {
        public override void confirm()
        {
            Console.WriteLine("Welcome to ABC school");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.id = 1;
            student.name = "XYZ";
            student.gender = "Male";
            student.confirm();
            Console.WriteLine(student.id);
            Console.WriteLine(student.name);
            Console.WriteLine(student.gender);


            school s = new school();
            s.confirm();




        }
    }
}
