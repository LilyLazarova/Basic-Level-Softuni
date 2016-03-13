using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_18.OddEven_Sum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int oddSum=0;
            int evenSum=0;

            for (int i = 1; i < 2*numberCount+1; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    oddSum += number;
                } 
                else
                {
                    evenSum += number;
                }
            } 
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum={0}", oddSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
