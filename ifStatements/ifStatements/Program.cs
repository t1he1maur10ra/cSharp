using System;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to see:");
            Console.Write("Type 1 for standard if's or 2 for if/else evaluations: ");
            string comparison = Console.ReadLine();
            if (comparison == "1")
            {
                string again = "y";//variable to allow the use to keep trying until they choose anything except y

                while (again == "y")
                {
                    Console.Clear();
                    ifs();//method to demo the if statements
                    Console.WriteLine("Do you want to try again?");
                    Console.Write("Type y to try again or n to quit: ");
                    again = Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (comparison == "2")
            {
                string again = "y";//variable to allow the use to keep trying until they choose anything except y

                while (again == "y")
                {
                    Console.Clear();
                    conditionals();//method to demo the if statements
                    Console.WriteLine("Do you want to try again?");
                    Console.Write("Type y to try again or n to quit: ");
                    again = Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Not a valid selection.");
            }
            Console.WriteLine("Good Bye");
            Console.ReadLine();
        }

        static void conditionals()//standard conditionals ony good in if/else scenario's
        {
            Console.WriteLine("Welcome to Jacob's Big Prize Giveaway");
            Console.Write("Choose 1 or 2: ");
            string userInput = Console.ReadLine();
            string message = (userInput == "1") ? "a BOAT" : "Jack Shit, HAHAHAHA!";
            /* 
            //Can be rewritten to be on a single line
            Console.Write("You won a ");
            Console.Write(message);
            Console.Write(".");
            */

            /*
            //Single line version
            Console.WriteLine("You won " + message + ".");
            */

            //Replacements
            Console.WriteLine("You entered: {0}, therefore you've won {1}", userInput, message);
        }

        static void ifs()//standard if's
        {
            string message;//message variable

            Console.WriteLine("Welcome to Jacob's Big Prize Giveaway");
            Console.Write("Choose 1, 2 or 3: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Clear();
                message = "You've won a car!";
            }
            else if (userInput == "2")
            {
                Console.Clear();
                message = "You've won a Banana";
            }
            else if (userInput == "3")
            {
                Console.Clear();
                message = "You've won a Million Dollars!";
            }
            else
            {
                message = "Sorry i didn't understand your response.";
                message += " To Bad";
            }

            Console.WriteLine(message);//display the appropriate message
        }

    }
}
