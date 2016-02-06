using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            //set properties

            Car OtherCar = myCar;

            Car newCar = new Car("Ford","Escape",2000,"Black");

            Car.mymethod(); //created without an object            
        }
    }
    class Car
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public String Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            //You could this from a configuration file,a database etc
            //i'll just hardcore in this instance
            this.Make = "Nissan";
        }

        public Car(String make,String model, int year, string color)
        {
            Make = make;
            Year = year;
            Model = model;
            Color = color;
        }

        /*public Car(String someOtherInputParameter, String model, int year, string color)
        {
            Make = someOtherInputParameter;
            Year = year;
            Model = model;
            Color = color;
        }*/
        
        public static void mymethod() // the word static  does not need an object to be called in main()
        {

        }
    }
}
