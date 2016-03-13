using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Decimal_to_Binary_Number
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter decimal number to convert to binary n = ");
            string input = Console.ReadLine();
            long number = long.Parse(input);
            long reminder = 0; 
            string result=string.Empty;

            while (number > 0)
            {
                reminder = number % 2;
                number = number / 2;
                result = reminder.ToString() + result;
            } Console.WriteLine(result);
            
        }
    }
}
