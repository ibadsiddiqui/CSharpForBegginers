using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.DarkRed; //Changes text color to red
            //Console.WriteLine("Hello World");

            Console.WriteLine("Enter Any name of super hero:");
            string heroName = Console.ReadLine();
            SuperHero value;

            if(Enum.TryParse < SuperHero > (heroName,true,out value))
            switch (value)
	        {
		        case SuperHero.Batman:
                    Console.WriteLine("Caped Crusader");
                    break;
                case SuperHero.Superman:
                    Console.WriteLine("Man of Steel");
                    break;
                case SuperHero.GreenLantern:
                    Console.WriteLine("Emrald Knight");
                    break;
                default:
                    break;
	        }
            else
                Console.WriteLine("Does not compute");
	        
            Console.Read();
        }
    }
    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern,
    }
}
