using System;

namespace objectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Integra";
            myCar.Year = 2017;
            myCar.Colour = "Green";

            Car myOtherCar;

            myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "XR6", 2014, "Black");
            
            Console.WriteLine("{0}, {1}, {2}, {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Colour);
            Console.WriteLine("{0}, {1}, {2}, {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Colour);
            Console.WriteLine("{0}, {1}, {2}, {3}",
                myThirdCar.Make,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Colour);

            Console.ReadLine();

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        /*public Car()
        {
            Make = "Nissan";
        }*/

        public Car(string make, string model, int year, string colour)
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
        }

        public Car()
        {
        }
    }
}
