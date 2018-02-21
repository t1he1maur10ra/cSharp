using System;
using System.Collections;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Mitsubishi";
            car1.Model = "Lancer";
            car1.Vin = "A1";

            Car car2 = new Car();
            car2.Make = "Toyota";
            car2.Model = "Caldina";
            car2.Vin = "B1";

            Book book1 = new Book();
            book1.Author = "Jacob Van Silfhout";
            book1.Title = "C# for dummies";
            book1.ISBN = "123-456-789a";

            /*//Array list are dynamic so are able to be sorted
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            //this will allow tha addition of anything into the arraylist which can cause issues when iterating through it

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }*/

            /*//list<>
            List<Car> mylist = new List<Car>();
            mylist.Add(car1);
            mylist.Add(car2);
            //mylist.Add(book1);//cant convert from a book to a car

            foreach (Car car in mylist)
            {
                Console.WriteLine(car.Make);
            }*/

            /*//Dictionary
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.Vin, car1);
            myDictionary.Add(car2.Vin, car2);

            Console.WriteLine("Please Enter a vin: ");
            string input = Console.ReadLine();

            Console.Write("The make of the car is: ");
            Console.Write(myDictionary["A1"].Make);*/

            string[] names = { "Jacob", "John", "Bob" };

            //Object initialisation
            Car car3 = new Car() { Make = "Jaguar", Model = "Type J", Vin = "C3" };
            Car car4 = new Car() { Make = "BMW", Vin = "D4", Model = "750li" };

            List<Car> MYlist = new List<Car>() {
                new Car {Make = "Subaru", Model = "WRX", Vin = "E5"},
                new Car {Make = "Subaru", Model = "Impreza", Vin = "F6"}
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
