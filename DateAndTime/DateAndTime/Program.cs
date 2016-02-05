using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());

            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());

            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            //DateTime myValue = new DateTime(1996,05,25);
            //Console.WriteLine(myValue.ToShortDateString());
        
            DateTime myBirthday = DateTime.Parse("1996/05/25");  //Verify your Birth date
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);  // Subtract the time now with your Birth date
            Console.WriteLine(myAge.TotalHours); //Tells Hours

            Console.Read();

        }
    }
}
