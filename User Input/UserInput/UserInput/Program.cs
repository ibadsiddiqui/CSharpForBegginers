using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userValue;
            //Console.WriteLine("Enter Any String for the Key");
            //userValue = Console.ReadLine();
            //Console.WriteLine("Enter Word is: " + userValue);

            Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3 ?");
            string userValue = Console.ReadLine();

            //string msg;
            //if (userValue == "1")
            //    msg = "You won a new Car!";
            //else if (userValue == "2")
            //    msg = "You won a new Bike!";
            //else if (userValue == "3")
            //    msg = "You won a new Mobile!";
            //else
            //    msg = "You Entered Wrong number.";

            //Console.WriteLine(msg);

            String msg = (userValue == "1") ? "Boat" : "Strand of lint";
            Console.WriteLine("You won a {0}", msg);
            Console.Read();
        }
    }
}
