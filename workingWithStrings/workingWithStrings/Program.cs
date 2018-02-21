using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life"; /*Add a backslash infront of the " to add it into a string*/
            //string myString = "what if i need a\nnew line?"; /*Add a new line into text*/
            //string myString = "Go to your C:\\ drive"; /*Add a backslash into text*/
            //string myString = @"Go to your C:\ drive"; /*Add an @ to the begining to let the runtime know that the backslash is what it is*/
            //string myString = string.Format("{0} = {1}", "First", "Second"); /*the assignment operators can be used in any order as well as repeatedly*/
            //string myString = string.Format("{0:N}", 1234567890123); /*Adds in the comma's and decimal points to numbers*/
            //string myString = string.Format("Percentage: {0:P}",0.125); /*Displays the text as a percentage*/
            //string myString = string.Format("Cell Number: {0:(0##) ###-####}",0276165962); /*Formats strings in the way specified*/

            //string myString = " Once apon a time there was a big bad wolf. ";
            //myString = myString.Substring(6, 17);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");

            /*
            myString = string.Format("Length befor: {0} - Length after: {1}",
                myString.Length,
                myString.Trim().Length);
            */

            /*
            string myString = "";
            for (int i = 0; i<101; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 101; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
