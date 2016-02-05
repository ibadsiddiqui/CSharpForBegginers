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
            //String myString = "What if i need \n a new line?";    //Introduce New line escape sequence

            //String myString = String.Format("{0}!", "Bonzai");    //String formating
            //String myString = String.Format("Make: {0} \nModel: {1}", "BMW","760li"); //String formating

            //String myString = String.Format("{0:C}", 12345);      //String formating with Dollar Sign
            //String myString = String.Format("{0:N}", 123456789);  //String formating of period 3 like in millions
            //String myString = String.Format("{0:P}", .12345);       //String formating of percentage

            //String myString = String.Format("Phone Number: {0 : (###) ### - ####}", 1234567890); //String formating

            /*String myString = " ";
            for (int i = 0; i < 100; i++)
            {
                myString += "--"+i.ToString();
            }*/

            //Stringbuilder class introduce
            /*StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i + "\n");
            }*/

            String myString = "  That summer we took Threes across the board ";
            //myString = myString.Substring(0);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            myString = String.Format("Length Before{0} -- After:{1}",
                                    myString.Length, myString.Trim().Length);

            Console.WriteLine(myString.ToString());
            Console.Read();
        }
    }
}
