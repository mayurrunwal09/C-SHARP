using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Customattribute
{
    
  

    public class info : Customattribute
    {
        
        public info(int id, string name, int age)
        {
            this.eid = id;
            this.ename = name;
            this.eage = age;
        }
        public int Id
        {

            get { return eid; }
        }
        public string Name
        {
            get { return ename; }
        }
        public int Age
        {
            get { return eage; }
        }
    }
    [info(1, "ABC", 35)]
    [info(2, "XYZ", 30)]
    [info(5, "DEF", 25)]


    public class print
    {

        public string str = "World";

        [info(3,"RAM",27)]
        public void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
        [info(4,"SHYAM",22)]
        public void display()
        {
            Count();
            Console.WriteLine("hello " + str);  
        }
    }
    
    public class show
    {
        public static void Main(string[] args)
        {

            print p = new print();
           
            p.display();
            Type type = typeof(print);


            foreach (Object o in type.GetCustomAttributes(false))
            {
                info i = (info)o;
             
                if(null != i)
                {
                    
                    Console.WriteLine(" emp id is: {0} , for object: {1} ", i.Id,i.GetType());
                    Console.WriteLine("emp name is:  "+ i.Name);
                    Console.WriteLine("emp age is:  "+ i.Age);
                }
            }

            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    info i = (info)a;

                    if (null != i)
                    {

                        Console.WriteLine("Emp id is : {0} , for method : {1} ", i.eid, m.Name);
                        Console.WriteLine("Emp name is : "+ i.ename);
                        Console.WriteLine("Emp age is : "+ i.eage);
                    }
                }
            }
        }
    }

}
