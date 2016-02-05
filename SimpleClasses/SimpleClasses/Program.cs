using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Color = "Blue";
            myNewCar.Year = 1990;
            myNewCar.Make = "OldsMobile";
            
            //Console.WriteLine(myNewCar.Color + "\n" + myNewCar.Model);
            Console.WriteLine("{0} - {1} - {2} - {3}",
                                myNewCar.Make,
                                myNewCar.Model,
                                myNewCar.Year,
                                myNewCar.Color);
            
            //double marketValueOfCar = determineMarketValue(myNewCar);
           
            Console.WriteLine("Car's Value: {0:C}", myNewCar.determineMarketValue());
            
            Console.Read();
        }
        private static double determineMarketValue(Car car)
        {
            double carValue = 100.0;

            //Look up car value and return it
            return carValue;
        }

    }
    
       
    class Car
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public String Color { get; set; }
        public double determineMarketValue()
        {
            double carValue = 100.0;
            if (this.Year > 1990)
                //Look up car value and return it
                carValue = 10000.0;
            else
                carValue = 20000.0;
            
            return carValue;
        }
    
    }
}
