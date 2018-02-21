using System;
using System.Collections;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Mitsubishi";
            car1.Model = "Lancer";

            Car car2 = new Car();
            car2.Make = "Toyota";
            car2.Model = "Caldina";

            Book book1 = new Book();
            book1.Author = "Jacob Van Silfhout";
            book1.Title = "C# for dummies";
            book1.ISBN = "123-456-789a";

            //Array list are dynamic so are able to be sorted
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            //this will allow tha addition of anything into the arraylist which can cause issues when iterating through it

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }

    class Car
    {
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
