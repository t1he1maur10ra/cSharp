using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace MyCodeLibrary
{
    public class FileScrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);
        }

        public string Scrapewebpage(string url)
        {
            string reply = GetWebpage(url);

            File.WriteAllText(@"C:\testing\googleHtml.txt", reply);//Use the privet method to write the info to a text file
            return reply;
        }

        private string GetWebpage(string url)//private function to get the webpage
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
