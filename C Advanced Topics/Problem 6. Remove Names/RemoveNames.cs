using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Remove_Names
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the first list of names, separated by empty space!");
            List<string> firstLine = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine("Please, enter the second list of names, separated by empty space!");
            List<string> secondLine = Console.ReadLine().Split(' ').ToList();

            
            for (int i = 0; i < secondLine.Count; i++)
            {
                for (int j = 0; j < firstLine.Count; j++)
                {
                    if (firstLine.Contains(secondLine[i]))
                    {
                        firstLine.Remove(secondLine[i]);
                    }
                }
            }
            foreach (var word in firstLine)
            {
                Console.Write(word + " ");
            }
        }
    }
}
