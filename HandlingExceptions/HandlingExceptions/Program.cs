using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader myReader = new StreamReader("Value.txt");
                String line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                myReader.Close();
            }

            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. are you sure the directory exist?");
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. are you sure you're looking for the correct file?");
            }

            catch(Exception e)
            {
                Console.WriteLine("Somthing didn't quite work correctly: {0} \n", e.Message);
            }
            
            finally
            {
                // perform any cleanup  to roll back the data or close connections
                // to files, database, networks etc.
            }
            Console.ReadLine();
            
            
        }
    }
}
