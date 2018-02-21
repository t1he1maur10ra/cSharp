using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //declare the array
            int[] stuff = new int[5];

            //initialise the contents of the array
            stuff[0] = 4;
            stuff[1] = 8;
            stuff[2] = 15;
            stuff[3] = 16;
            stuff[4] = 23;

            Console.WriteLine(stuff[1]);
            Console.WriteLine(stuff.Length);//displays the the numbver of elements in the array
            Console.ReadLine();
            */

            /*
            //intialise the array at the time of creation
            int[] stuff = new int[] { 4, 5, 6, 7, 8, 12, 19, 27 };
            */

            string[] names = new string[] { "Jacob", "John", "Jason", "Jerremy" };

            /*
            //uses a for loop to itterate through the array
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);//wil preint the name associated with the position in the array at i
            }
            Console.ReadLine();
            */

            /*
            //uses a foreach loop to go through the array
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string chur = "Hello" + " World";//concatenates the strings together
            char[] charArray = chur.ToCharArray();//Creates and puts the characters into an array
            Array.Reverse(charArray);//Reverses the charArray

            foreach (var churChar in charArray)
            {
                Console.Write(churChar);
            }
            Console.ReadLine();
        }
    }
}
