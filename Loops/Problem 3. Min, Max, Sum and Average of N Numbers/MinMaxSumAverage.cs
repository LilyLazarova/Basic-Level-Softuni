using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Min__Max__Sum_and_Average_of_N_Numbers
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            int sum = 0;
            double average = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;
                                
                if (inputNumber>maxValue)
                {
                    maxValue = inputNumber;
                }
                if (inputNumber<minValue)
                {
                    minValue = inputNumber;
                }
            }
            average = (double)sum / (double)numbersCount;
            Console.WriteLine("min = {0}",minValue);
            Console.WriteLine("max = {0}",maxValue);
            Console.WriteLine("sum = {0}",sum);
            Console.WriteLine("average = {0:f2}", average);
            
        }
    }
}
