//Problem 21.	** – Odd / Even Elements
//You are given N numbers. Calculate the sum, min and max of its odd elements and sum, min and max of its even elements. Consider that the first element is odd, the second is even, etc.
////Input
//The input data should be read from the console. It will consists of exactly one line.
//•	At the first line N numbers will be given, separated one from another by a single space.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//You have to print the output in a single line at the console in the following format:
//•	OddSum=…, OddMin=…, OddMax=…, EvenSum=…, EvenMin=…, EvenMax=…
//Print the numbers in the output without any unneeded trailing zeroes (i.e. print 1.5 instead of 1.50; 1 instead of 1.00). In case the sum, the minimal or the maximal element cannot be calculated (due to missing data), print "No".
//Constraints
//•	All numbers in the input will be in the range [-1 000 000 … 1 000 000], with no more than 10 digits (total, before and after the decimal point). The decimal separator in the non-integer numbers will be '.' and the numbers will have up to 2 digits after the decimal separator.
//•	The count N of the numbers in the input is in the range [0 … 1000].
//•	All numbers in the output should be formatted without unneded trailing zeroes.
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input	Output
//2 3 5 4 2 1	OddSum=9, OddMin=2, OddMax=5, EvenSum=8, EvenMin=1, EvenMax=4
//3 -2 8 11 -3	OddSum=8, OddMin=-3, OddMax=8, EvenSum=9, EvenMin=-2, EvenMax=11
//1	OddSum=1, OddMin=1, OddMax=1, EvenSum=No, EvenMin=No, EvenMax=No
//1.5 -2.5	OddSum=1.5, OddMin=1.5, OddMax=1.5, EvenSum=-2.5, EvenMin=-2.5, EvenMax=-2.5
//1.5 1.75 1.5 1.75	OddSum=3, OddMin=1.5, OddMax=1.5, EvenSum=3.5, EvenMin=1.75, EvenMax=1.75



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_21.Odd_Even_Elements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else
            {
                string[] numbersInputString=input.Split(' ');
                //double[] numbers = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                

                double[] numbers = Array.ConvertAll(numbersInputString, double.Parse);
                
                double oddSum = 0;
                double evenSum = 0;
                double oddMin = double.MaxValue;
                double evenMin = double.MaxValue;
                double oddMax = double.MinValue;
                double evenMax = double.MinValue;
              
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers = Array.ConvertAll(numbersInputString, double.Parse);
                    if (i % 2 == 0)
                    {
                        oddSum += numbers[i];
                        if (numbers[i] < oddMin)
                        {
                            oddMin = numbers[i];
                        } if (numbers[i] > oddMax)
                        {
                            oddMax = numbers[i];
                        }
                    }
                    else
                    {
                        evenSum += numbers[i];
                        if (numbers[i] < evenMin)
                        {
                            evenMin = numbers[i];
                        } if (numbers[i] > evenMax)
                        {
                            evenMax = numbers[i];
                        }
                    }
                }
                if (numbers.Length == 1)
                {
                    Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);
                }
                else
                {
                    Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
                }
            }
            }
            
            
        }
    }


//=======================================================================================

//using System;

//class OddEvenElements
//{
//    static void Main()
//    {
//        System.Threading.Thread.CurrentThread.CurrentCulture =
//            System.Globalization.CultureInfo.InvariantCulture;

//        decimal oddSum = 0;
//        decimal oddMin = decimal.MaxValue;
//        decimal oddMax = decimal.MinValue;
//        decimal evenSum = 0;
//        decimal evenMin = decimal.MaxValue;
//        decimal evenMax = decimal.MinValue;

//        string input = Console.ReadLine();
//        string[] inputNumbers = input.Split(' ');
//        if (input == "")
//        {
//            // Known issue: split on empty string returns 1 token ""
//            inputNumbers = new string[0];
//        }

//        bool odd = true;
//        for (int i = 0; i < inputNumbers.Length; i++)
//        {
//            decimal element = decimal.Parse(inputNumbers[i]);
//            if (odd)
//            {
//                oddSum += element;
//                oddMin = Math.Min(oddMin, element);
//                oddMax = Math.Max(oddMax, element);
//            }
//            else
//            {
//                evenSum += element;
//                evenMin = Math.Min(evenMin, element);
//                evenMax = Math.Max(evenMax, element);
//            }
//            odd = !odd;
//        }

//        if (inputNumbers.Length == 0)
//        {
//            Console.WriteLine(
//                "OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
//        }
//        else if (inputNumbers.Length == 1)
//        {
//            Console.WriteLine(
//                "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
//                (double)oddSum, (double)oddMin, (double)oddMax);
//        }
//        else
//        {
//            Console.WriteLine(
//                "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
//                (double)oddSum, (double)oddMin, (double)oddMax,
//                (double)evenSum, (double)evenMin, (double)evenMax);
//        }
//    }
//}
