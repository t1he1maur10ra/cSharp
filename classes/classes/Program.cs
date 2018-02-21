using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.make = "Mitsubishi";
            myCar.model = "Lancer";
            myCar.year = 2017;
            myCar.colour = "Yellow";

            Console.WriteLine("{0}, {1}, {2}, {3}", 
                myCar.make, 
                myCar.model, 
                myCar.year, 
                myCar.colour);

            //Console.WriteLine(("Car is worth $" + determineMarketValue(myCar)));
            Console.WriteLine("Your car is worth $"+myCar.DetermineMarketValue());

            Console.ReadLine();
        }

        private static decimal determineMarketValue(Car car)
        {
            decimal carValue = 100.00M;
            return carValue;
        }
    }
    class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string colour { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (year > 2012)
                carValue = 10000.00M;
            else
                carValue = 3000.00M;

            return carValue;

        }
    }

}
