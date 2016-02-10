using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScopes
{
    class Program
    {
     //   private static string k = "";   //Global variable can be accesse anywhere
        static void Main(string[] args)
        {
       /*     string j = "";                  //global variable but cannot be acced outside main()
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();   
                }
                //Console.WriteLine(l); //out of if scope
            }
            //Console.Write(i);

            Console.WriteLine("Outside of Loop:" + j);
            helperMethod();
            
           */ 

            Car car = new Car();
            car.DoSomething();
            Console.Read();
        }
        /*static void helperMethod()
        {
            Console.WriteLine(k);
        }*/
    }
    class Car
    {
        public void DoSomething()       //can be access by other classes and Uppercase words
        {
            Console.WriteLine(helperMethod());

        }

        private string helperMethod()       //cannot be accessed
        {                                   //Private method starts with lower keyword
            return "Hello Word";
        }
        
    }
}
