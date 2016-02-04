using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReadTextWhileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt");
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
