using System;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue);//Shows the current date and time
            Console.WriteLine(myValue.ToString());//Converts the date to a string
            Console.WriteLine(myValue.ToShortDateString());//Shows the date in a shorter format
            Console.WriteLine(myValue.ToShortTimeString());//Shows the time in a shorter format
            Console.WriteLine(myValue.ToLongDateString());//Shows the full date
            Console.WriteLine(myValue.ToLongTimeString());//Shows the full time
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());//Adds 3 days to the current date
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());//Subtracts 3 days from the current date
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());//Adds 3 hrs to the current time
            Console.WriteLine(myValue.Month);//Shows the numerical value for the current month

            DateTime myBirthday = new DateTime(1979, 3, 9);//assign my birthday
            Console.WriteLine(myBirthday);//Displays

            DateTime birth = DateTime.Parse("9/3/1979");
            TimeSpan myAge = DateTime.Now.Subtract(birth);
            Console.WriteLine(myAge.TotalDays);//Displays the total day since i was born

            Console.ReadLine();
        }
    }
}
