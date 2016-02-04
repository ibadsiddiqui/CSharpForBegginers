using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Declerations
           /* int[] num = new int[6];     //Array (A Bucket) name variable created Which can contains 6 integer values 
            num[0] = 1;                 // Array position starts at 0 (indexing number  = 0)ss
            num[1] = 2;
            num[2] = 3;
            num[3] = 4;
            num[4] = 5;
            num[5] = 6;

            for (int i = 0; i < 6; i++)
                Console.WriteLine(num[i]);
            */
            //Another way of Decleration is:
           
            /*int[] number = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(number[i]);

            }
            */

            //Another way of String Decleration is:

            String[] names = new String[] {"ibad","Ali","Areeb","Arbab","Sherry"};
            foreach (String name in names)
            {
                Console.WriteLine(name);

            }
            
            Console.Read();
        }
    }
}
