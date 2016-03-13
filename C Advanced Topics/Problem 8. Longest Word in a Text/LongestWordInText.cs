using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Longest_Word_in_a_Text
{
    class LongestWordInText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a text to find the longest word in it");
            string[] text = Console.ReadLine().Split(new char[] {' ','.',',','!','?'},StringSplitOptions.RemoveEmptyEntries).ToArray();
            int longestWordIndex=0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length> longestWordIndex)
                {
                    longestWordIndex = i;
                }
            }
            Console.WriteLine("Longest word is : {0}", text[longestWordIndex]);
        }
    }
}
