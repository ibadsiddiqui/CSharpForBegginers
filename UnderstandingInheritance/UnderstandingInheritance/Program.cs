using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Year = 2005;
            myCar.Color = "Black";

            printCarDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 20000;
            printCarDetails(myTruck);

            Console.Read();
        }

        private static void printCarDetails(Car car)
        {
            Console.WriteLine("Here are the Car's details {0}",car.FormatMe());

        }
    }

    class Car
    {
        public string Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public String Color { get; set; }

        public String FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3} ", this.Make,
            this.Model,
            this.Year,
            this.Color);
        }
    }

    class Truck : Car
    {
        public int TowingCapacity { get; set; }

    
    }
}
