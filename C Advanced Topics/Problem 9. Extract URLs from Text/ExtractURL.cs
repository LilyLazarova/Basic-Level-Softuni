using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Extract_URLs_from_Text
{
    class ExtractURL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a text to extract URLs from it:");
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string http = "http://";
            string www = "www.";

            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Contains(http) || text[i].Contains(www))
                {
                    Console.WriteLine(text[i]);
                }
            } Console.WriteLine();
        }
    }
}
