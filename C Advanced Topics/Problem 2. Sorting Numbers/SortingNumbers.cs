using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem_2.Sorting_Numbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
//            Stopwatch stopWatch = new Stopwatch();
//            stopWatch.Start();
            Console.Write("Please, enter the count of numbers n = ");
            int numbersCount = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[numbersCount] ;
            int minNumber = int.MinValue;

            for (int k = 0; k < numbersCount; k++)
            {
                Console.Write("Number[{0}] = ", k + 1);
                int number = int.Parse(Console.ReadLine());
                numbersArray[k] = number;
            }
            Console.WriteLine();

            for (int i = numbersArray.Length; i > 0; i--)                   //This for loops are the fastest way for bubble sorting(it's working with for(int j = 0; j < numbersArray.Length - 1; j++) as well and for( int i = 0; i < numbersArray.Length; i++),but slower that this
            {
               for (int j = 0; j < i - 1; j++)
                {

                    if (numbersArray[j] > numbersArray[j + 1])
                    {
                        minNumber = numbersArray[j];
                        numbersArray[j] = numbersArray[j + 1];
                        numbersArray[j + 1] = minNumber;
                    }
                }
            }
            Console.Write("Sorted numbers are: ");     
            foreach (var num in numbersArray)
                {
                    Console.Write(num + " ");
                } Console.WriteLine();

            //stopWatch.Stop();
            //TimeSpan result = stopWatch.Elapsed;
            //Console.WriteLine(result);
            }
        
}
}
    
