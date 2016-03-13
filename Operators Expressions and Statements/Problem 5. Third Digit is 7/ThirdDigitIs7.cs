using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Third_Digit_is_7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int number = 0;
            bool isNumberInt = int.TryParse(Console.ReadLine(), out number);
            int numberDevided = Math.Abs(number / 100);                     //Math.Abs is used to be able the program to work even if the entered number is negative.
            int numberNew = Math.Abs(numberDevided % 10);

            if (isNumberInt)
            {
                if (numberNew == 7)
                {
                    Console.WriteLine("Third digits is 7? : true");
                }
                else
                {
                    Console.WriteLine("Third digits is 7? : false");
                }
            }
            else
            {
                Console.WriteLine("Please, enter valid integer number!");
            }
        }
    }
}
