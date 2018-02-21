using System;
using MyCodeLibrary;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FileScrape Scrape = new FileScrape();
            string value = Scrape.ScrapeWebpage("https://www.google.com");
            Scrape.Scrapewebpage("https://www.google.com");
            Console.WriteLine(value);
            Console.WriteLine("Chur, it worked. MEAN.");
            Console.ReadLine();
        }
    }
}
