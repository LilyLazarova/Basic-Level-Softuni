//Write a program that finds the biggest of three numbers. Examples:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.The_Biggest_of_3_Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter 3 numbers below.");
            double[] numbers = new double[3];
            double max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine()) ;
            }
            max = numbers.Max();
            Console.WriteLine("Max number is : {0}", max);
        }
    }
}
