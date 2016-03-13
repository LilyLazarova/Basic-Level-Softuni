using System;
using System.Linq;


class SumOfElements
{
    static void Main()
    {
        
        string[] elements = Console.ReadLine().Split(' ');                  //create an array with elements input from the console excluding the space
        decimal[] elementsInt = Array.ConvertAll(elements, Decimal.Parse);          //convert string array to int array

      
        decimal maxValue = elementsInt.Max();                                   //get the element with max value in the array
       // int maxValuePosition = Array.IndexOf(elementsInt,maxValue);         //get the position of the element with max value
        decimal sum = elementsInt.Sum() - maxValue;
        decimal diff = Math.Abs(maxValue - sum);
     

        if (sum == maxValue)
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            Console.WriteLine("No, diff={0}",diff);    
        }
        
    
    }
}



//===============================================================================================

//using System;

//class SumOfElements
//{
//    static void Main()
//    {
//        string inputLine = Console.ReadLine();
//        string[] numbers = inputLine.Split(' ');

//        long max = long.MinValue;
//        long sum = 0;
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            long element = long.Parse(numbers[i]);
//            sum = sum + element;
//            if (element > max)
//            {
//                max = element;
//            }
//        }

//        if (sum == 2 * max)
//        {
//            Console.WriteLine("Yes, sum=" + max);
//        }
//        else
//        {
//            long diff = Math.Abs(sum - 2 * max);
//            Console.WriteLine("No, diff=" + diff);
//        }
//    }
//}
