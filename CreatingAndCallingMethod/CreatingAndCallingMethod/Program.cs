using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAndCallingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string h1 = Me("Ibad");
            Console.WriteLine(h1);

            Console.Read();
        }

        private static String hello()
        {
            return "Hello World";
        }
        private static String Me(String name)
        {
            return String.Format("Hello {0}!",name);
        }
    }
}
