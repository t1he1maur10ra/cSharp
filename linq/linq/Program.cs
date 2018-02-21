using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            List<Car> myCars = new List<Car>() {
                new Car() {VIN = "a", Make = "Mitsubishi", Model = "Lancer", Year = 2010, Price = 40000},
                new Car() {VIN = "b", Make = "Honda", Model = "Integra", Year = 2012, Price = 20000},
                new Car() {VIN = "c", Make = "Toyota", Model = "Caldina", Year = 2011, Price = 14000},
                new Car() {VIN = "d", Make = "Mitsubishi", Model = "Mirage", Year = 2009, Price = 9000},
            };
            //LINQ Query
            /*
            var mitsis = from car in myCars
                         where car.Make == "Mitsubishi"
                         && car.Year == 2009//Allows multiple where statements
                         select car;
            */
            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            //LINQ Methods
            //var mitsis = myCars.Where(p => p.Make == "Mitsubishi" && p.Year == 2010);//the compiler figures out what the var is by itself
            //var orderedCars = myCars.OrderByDescending(p => p.Year);
            /*
            var firstCar = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "Mitsubishi");
            Console.WriteLine(firstCar.VIN);
            */
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2008));

            //myCars.ForEach(p => p.Price -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.Price));

            //Console.WriteLine(myCars.Exists(p => p.Model == "Integra"));
            //Console.WriteLine("{0:C}",myCars.Sum(p => p.Price));

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Model, car.VIN, car.Year);
            }
            */

            //Looking at the datatypes of VAR
            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());
            var mitsis = myCars.Where(p => p.Make == "Mitsubishi" && p.Year == 2010);
            Console.WriteLine(mitsis.GetType());


            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
}
