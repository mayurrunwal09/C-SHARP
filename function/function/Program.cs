using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    public class Program
    {
        
      /*
        // 1-Function without parameter
        public void fun()  // no parameter in the method
        {
            Console.WriteLine("No parameter");
        }
        static void Main(string[] args)
        {
            Program f1 = new Program(); // f1 is a object of class program which will use to call the method.
            f1.fun(); // f1.called method fun()
        }                               // output-No parameter
                                       //         Press any key to continue . . .
      */



       /* 
      //2-function using parameter
      public void fun(string name,int id,long mobile_no,string adress)//there is parameter in the function.
        {
            Console.WriteLine("Mayur" + name,10);
            Console.WriteLine(id);
            Console.WriteLine(mobile_no);
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            Program f1 = new Program(); 
            f1.fun("Runwal",10,9923428304,"Nasik");
        }
                                                                // Output- MayurRunwal
                                                                //10
                                                                //9923428304
                                                                //Runwal
                                                               //Press any key to continue . . .
       */


        /*
        
                //3-function using parameter and return type
                public string function(string message) // the parameter will be in string
                {
                    Console.WriteLine("message");
                    return message; // using return keyword it will show methods parameter.
                }
                static void Main(string[] args)
                {
                    Program p1 = new Program();
                    string message = p1.function("Hello");
                    Console.WriteLine("Mayur " + message);// the output will be hello mayur.
                }
                                             //  Output-     message
                                              //      Mayur Hello
                                              //      Press any key to continue . . .
        */

        /*
        //4- function call by value  
        public void fun(int no) //a parameter int is pass to the function
        {
            no *= no; // it well return the sqaure root of value. i.e-parameter no * number.
            Console.WriteLine("The number is " + no);
        }
        static void Main(string[] args)
        {
            int no = 5;
            Program p1 = new Program();
            Console.WriteLine("number before calling the function: "+no);
            p1.fun(no);
            Console.WriteLine("number after calling the function");
        }
                                              //  output-  number before calling the function: 5
                                             //           The number is 25
                                              //          number after calling the function
                                              //          Press any key to continue . . .
        */

        /*
        
                // 5-call by reference
                public void fun(ref int no)  // there is parameter int which will be called by reference.
                {
                    no += no;    // the output of int no will be add with the no itself.
                    Console.WriteLine("The number is: "+no); 



                }
                static void Main(string[] args)
                {
                    int no = 5;

                    Program p1 = new Program(); ///p1 is the object
                    Console.WriteLine("number before calling function "+no); //it will be called first
                    p1.fun(ref no);
                    Console.WriteLine("number after calling function "+no);// the output will be show at last

                }
                                                     //  output- number before calling function 5
                                                     //         The number is: 10
                                                     //       number after calling function 10
                                                     //     Press any key to continue . . .
        */
/*
        // out paramter
        public void fun(out int num)
        {
            int sqaure = 10;
            num = sqaure; ;
            num *= num;

        }
        static void Main(string[] args)
        {
            int num = 20;
            Program p1 = new Program();
            Console.WriteLine("the number before passing out "+num);
            p1.fun(out num);
            Console.WriteLine("the number after passing out " + num);
        }
                                           //output-  the number before passing out 20
                                         //   the number after passing out 100
                                          //  Press any key to continue . . .
            
        */


    }
}
