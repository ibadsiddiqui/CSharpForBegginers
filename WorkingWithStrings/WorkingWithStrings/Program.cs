using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //String myString = "Go to your C:\\ drive";    
            //String myString = "My \"so called\" Life"; //We use backslash for inside double quoting
            //String myString = "What if i need \n a new line?";  //Introduce New line escape sequence

            //String myString = String.Format("{0}!", "Bonzai"); //String formating
            //String myString = String.Format("Make: {0} \nModel: {1}", "BMW","760li"); //String formating

            //String myString = String.Format("{0:C}", 12345); //String formating with Dollar Sign
            //String myString = String.Format("{0:N}", 123456789); //String formating of period 3 like in millions
            String myString = String.Format("{0:P}", .12345); //String formating


            Console.WriteLine(myString);
            Console.Read();
        }
    }
}
