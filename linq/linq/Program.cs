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
                new Car() {VIN = "a", Make = "Mitsi", Model = "Lancer", Year = 2010},
                new Car() {VIN = "b", Make = "Honda", Model = "Integra", Year = 2012},
                new Car() {VIN = "c", Make = "Toyota", Model = "Caldina", Year = 2011},
                new Car() {VIN = "d", Make = "Mitsi", Model = "Mirage", Year = 2009},
            };
            //LINQ Query


            //LINQ Methods



            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
