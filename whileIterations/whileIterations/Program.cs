using System;

namespace whileIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool option = true;
            while (option == true)
            {
                option = displayMenu();//Keeps displaying the menu while the user doesnt select 3
            }
        }

        private static bool displayMenu()//Nonvoid as it returns a value
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1: Guessing Game");
            Console.WriteLine("2: Numbers");
            Console.WriteLine("3: exit");
            int result = int.Parse(Console.ReadLine());
            if (result == 1)
            {
                option1();
                return true;
            }
            else if (result == 2)
            {
                option2();
                return true;
            }
            else if (result == 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void option1()//void cause it doesnt return anything
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Guessing Game section!");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool guess = true;
            do//Do While loop
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string input = Console.ReadLine();
                guesses++;
                if (input == randomNumber.ToString())
                {
                    Console.WriteLine("YAY you got it! Press ENTER to continue:");
                    Console.ReadLine();
                    guess = false;
                }
                else
                {
                    Console.WriteLine("WRONG!");
                }
            } while (guess);
            Console.WriteLine("It only took you " + guesses + " guesses.");
            Console.ReadLine();
        }

        private static void option2()//void cause it doesnt return anything
        {
            Console.Clear();
            Console.WriteLine("Welcome to the number section!");
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            while ( counter < input + 1)//Standard while loop
            {
                Console.Write(counter+ " ");
                counter++;
            }
            Console.ReadLine();
        }
    }
}
