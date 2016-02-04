using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextWhileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //If we use StreamReader.. it is  also ok
            System.IO.StreamReader myReader = new StreamReader("Values.txt");
            String line = "";

            while(line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
                
            }
            myReader.Close();

            Console.Read();
        }
    }
}
