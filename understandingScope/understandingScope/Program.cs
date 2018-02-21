using System;

namespace understandingScope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";
            for(int i=0; i<11; i++)
            {
                j = i.ToString();
                k = j;
                Console.WriteLine(i);
            }
            Console.WriteLine("j = " +j);
            Console.WriteLine("k = " +k);
            helper();
            Car newCar = new Car();
            newCar.DoSomething();//can only see the doSomething method because its public
            Console.ReadLine();
        }

        static void helper()
        {
            Console.WriteLine(k);
        }
    }
     class Car
    {
        public void DoSomething()//Public Method, used as the interface to the private method
        {
            Console.WriteLine(HelperMethod());
        }
        private string HelperMethod()//Private method, can only be seen from inside the Car class
        {
            return "Hello World";
        }
    }
}
