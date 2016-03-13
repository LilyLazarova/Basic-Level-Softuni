using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allNumbers = new List<int>();                     //Similar to Array
            int numberCounts = int.Parse(Console.ReadLine());

           for (int i = 0; i < numberCounts; i++)
			{
			 int currentNumber=int.Parse(Console.ReadLine());
             allNumbers.Add(currentNumber);
			}

           int maxNumber = allNumbers.Max();
           Console.WriteLine(maxNumber);
           
        }
    }
}
