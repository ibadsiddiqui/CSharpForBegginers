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
            string h1 = hello();
            Console.WriteLine(h1);

        }

        private static String hello()
        {
            return "Hello World";
        }
    }
}
