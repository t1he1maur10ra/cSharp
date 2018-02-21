using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string text = "hmmmmmmmmmmmmmmmm?";
            File.WriteAllText(@"C:\testing\testing.txt", text);//From the system.io namespace
            Console.ReadLine();
            
            WebClient client = new WebClient();//From the system.net namespace
            string reply = client.DownloadString("https://www.google.com");//From the system.net namespace
            File.WriteAllText(@"C:\testing\googleHtml.text", reply);//From the system.io namespace

            Console.WriteLine(reply);
            Console.ReadLine();

        }
    }
}
