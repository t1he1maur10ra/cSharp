using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the nessessary variables to be passed around
            int x = 7;
            int y = 0;
            String fullName;

            //Do the maths in a separate method
            Console.WriteLine("Section 1: Maths opperation for Y = X + 3");
            y = maths(x, y);
            Console.WriteLine(y);
            Console.ReadLine();

            //Obtain the full name in another method
            Console.WriteLine("Section 2: Obtain the name in parts and combine");
            fullName = names();
            Console.WriteLine("Hello " + fullName + ", nice to meet you!");
            Console.ReadLine();

            
        }
        static int maths(int a,int b)
        {
            //perform opperations on the variables
            b = a + 3;
            return b;
        }

        static string names()
        {
            //Obtain the parts of the name
            Console.WriteLine("Hello, whats your name:");
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();//Variable decleration inline
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();//Variable decleration inline

            //Combine the 2 parts of the name
            string full = firstName + " " + lastName;//Variable decleration inline

            //Return the users full name
            return full;
        }
    }
}
