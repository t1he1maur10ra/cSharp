using System;

namespace forIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //forLoop();
            forNestedIf();
        }
        static void forLoop()
        {
            //Standad for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static void forNestedIf()
        {
            //Standad for loop
            for (int i = 0; i < 10; i++)//Can be auto generated using intelisense and double TAB to create
            {
                Console.WriteLine(i);
                if (i == 7)//Creates a pause at this break point to monitor the program as its running
                {
                    Console.WriteLine("Found the number 7!");
                    break;
                }  
            }
            Console.ReadLine();
        }
    }
}
