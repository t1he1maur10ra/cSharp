using System;
using System.IO;

namespace HandlingExceptions//Learning to code defensively
{
    class Program
    {
        static void Main(string[] args)//looking at using the try catch to protect the end user from being confused when exceptions happen.
        {
            try//try this section of code
            {
                string content = File.ReadAllText(@"C:\testing\testing.txt");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)//work your way through the exceptions starting with the most specific
            {
                Console.WriteLine("Please check you file path");
                Console.WriteLine(ex.Message);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please make sure the file directory exists");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)//if the previous try doesn't work then this will happen
            {
                Console.WriteLine("Couldn't find the specified file.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Add code to reset things. ie set to null.
                //Close connections to databases.
                Console.WriteLine("Closing the current application.....");
            }
            Console.ReadLine();
        }
    }
}