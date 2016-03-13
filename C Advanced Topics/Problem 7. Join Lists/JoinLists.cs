using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Join_Lists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            // input

            Console.WriteLine("Please, enter the first line of integers:");
            List<int> firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Please, enter the second line of integers:");
            List<int> secondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //remove repeating elements
            for (int i = 0; i < firstLine.Count; i++)
            {
                    if (secondLine.Contains(firstLine[i]))
                    {
                        secondLine.Remove(firstLine[i]);
                    }
            }

            //join the strings and remove duplicates

            firstLine.AddRange(secondLine);                                                 //Add secondLine list to firstLine list
            List<int> listWithoutDuplicates = firstLine.Distinct().ToList();                //remove duplicates from firstLine List
            

            //arrange in increasing order

            for (int i = listWithoutDuplicates.Count; i > 0; i--)
            {
               for (int j = 0; j < i-1 ; j++)
			{
			 		
                int minNumber = int.MinValue;
                if (listWithoutDuplicates[j] > listWithoutDuplicates[j + 1])
                {
                    minNumber = listWithoutDuplicates[j + 1];
                    listWithoutDuplicates[j + 1] = listWithoutDuplicates[j];
                    listWithoutDuplicates[j] = minNumber;
                }

            }
            }

            //Print
                      
            foreach (var number in listWithoutDuplicates)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
    }

