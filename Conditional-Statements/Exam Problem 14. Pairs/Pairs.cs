//You are given 2*N elements (even number of integer numbers). The first and the second element form a pair, the third and the fourth element form a pair as well, etc. Each pair has a value, calculated as the sum of its two elements. Your task is to write a program to check whether all pairs have the same value or print the max difference between two consecutive values.
//Input
//You are given at the console even number of integers, all in a single line, separated by a space.
//Output
//The output is single line, printed at the console.
//•	In case all pairs have the same value, print "Yes, value=…" and the value.
//•	Otherwise, print "No, maxdiff=…" and the maximal difference between two consecutive values, always a positive integer.
//Constraints
//•	All input values will be integers in the range [-1000…1000] inclusive.
//•	The count of elements is even number in the range [2…1000] inclusive.
//•	Allowed work time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input	Output	Comments
//1 2 0 3 4 -1	Yes, value=3	values = {3, 3, 3} --> equal values
//1 2 2 2	No, maxdiff=1	values = {3, 4}, different values --> max difference = 4-3 = 1
//1 1 3 1 2 2 0 0	No, maxdiff=4	values = {2, 4, 4, 0}, differences = {2, 0, 4}, max difference = 4
//5 5	Yes, value=10	values = {10} --> single value --> equal values
//-1 0 0 -1	Yes, value=-1	values = {-1, -1}, equal values


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_14.Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] separatedInput = input.Split(' ');
            int[] numbers = Array.ConvertAll(separatedInput,int.Parse);

            int countOfPairs = (numbers.Length) / 2;
            int[] pairArray = new int[countOfPairs];
            int[] diffArray = new int[countOfPairs-1];
            int pair = 0;
            int count = 0;
            int diff = 0;
            int maxValue = 0;
            for (int i = 0; i < numbers.Length; i += 2)
            {
                int j = i / 2;
                
                pair = numbers[i] + numbers[i + 1];
                pairArray[j] = pair;

            }
            for (int k = 0; k < pairArray.Length-1; k++)
            {
               if (pairArray[k] == pairArray[k+1])
               {
                   count++;
               }
            }
            
            if ((count + 1)==countOfPairs)
            {
                Console.WriteLine("Yes, value={0}",pair);
            }
            else
            {
                for (int l = 0; l < pairArray.Length-1; l++)
                {
                    diff = Math.Abs(pairArray[l + 1] - pairArray[l]);
                    diffArray[l] = diff;
                }
                for (int i = 0; i < diffArray.Length; i++)
                {                 
                    maxValue = Math.Abs(diffArray.Max());
                } Console.WriteLine("No, maxdiff={0}", maxValue);
                
            }
         }

        }
    }

//===========================================================================
//using System;

//class Pairs
//{
//    static void Main()
//    {
//        string inputLine = Console.ReadLine();
//        string[] elements = inputLine.Split(' ');

//        int firstElement = int.Parse(elements[0]);
//        int secondElement = int.Parse(elements[1]);
//        int prevValue = firstElement + secondElement;

//        int maxdiff = 0;
//        for (int i = 2; i < elements.Length - 1; i+=2)
//        {
//            firstElement = int.Parse(elements[i]);
//            secondElement = int.Parse(elements[i+1]);
//            int lastValue = firstElement + secondElement;
//            int diff = Math.Abs(lastValue - prevValue);
//            maxdiff = Math.Max(diff, maxdiff);
//            prevValue = lastValue;
//        }

//        if (maxdiff == 0)
//        {
//            Console.WriteLine("Yes, value=" + prevValue);
//        }
//        else
//        {
//            Console.WriteLine("No, maxdiff=" + maxdiff);
//        }
//    }
//}