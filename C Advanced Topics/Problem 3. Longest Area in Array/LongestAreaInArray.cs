using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Longest_Area_in_Array
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the number of strings n = ");
            int numberOfStrings = int.Parse(Console.ReadLine());
            string[] words = new string[numberOfStrings];
            int countOfEqualStrings = 1;
            int bestCount = 1;
            int bestLength = 0;
            string word = words[0];
            int index = 0;

            for (int i = 0; i < numberOfStrings; i++)
            {
                words[i] = Console.ReadLine();
            }
            for (int j = 0; j < numberOfStrings - 1; j++)
            {
                bool isStringsEqual = words[j].Equals(words[j + 1]);  //compare if 2 strings are equal

                if (isStringsEqual)
                {
                    countOfEqualStrings++;

                    if (countOfEqualStrings > bestCount)
                    {
                        bestCount = countOfEqualStrings;
                        index = j;
                    }
                }
                else
                {
                    countOfEqualStrings = 1;
                }
            } 
            if (bestCount==1)
            {
                for (int i = 0; i < numberOfStrings; i++)
                {
                    int length = words[i].Length;

                    if (length > bestLength)
                    {
                        bestLength = length;
                        index = i;
                    }
                }
            }
            Console.WriteLine(bestCount);

            for (int i = 0; i < bestCount; i++)
            {
                Console.WriteLine(words[index]);
            }
        }
    }
}
