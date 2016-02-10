using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type i a super herp's name tp see his nickname:");
            string value = Console.ReadLine();

            switch (value)
            {
                case "BATMAN":
                    Console.Write("Caped Crusador");
                    break;
                case "SUPERMAN":
                    Console.WriteLine("Man of Steel");
                    break;
                case "GREENLANTERN":
                    Console.WriteLine("Emrald Knight");
                    break;
                default:
                    Console.WriteLine("Does not compute.");
                    break;
            }
            Console.Read();
        }
    }
}
