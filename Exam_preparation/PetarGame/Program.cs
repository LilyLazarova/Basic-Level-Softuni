//Problem 2 – Petar's Game
//Petar likes to play with numbers. He is very good with strings too. One day he decided to invent a new game of summing numbers. He will get one number and will try to divide it by 5, if the number can be divided without remainder (for example 15 can be divided by 5 without remainder, but 17 divided by 5 is 3 with remainder 2) Petar will add this number to the sum. However if the number cannot be divided without remainder, only the remainder will be added to the sum. After he is done with the numbers, Petar likes to replace some of the sum's digits with strings. If the sum is odd he will replace the last digit and all others that are the same as it with a given string. If the sum is even he will do the same, but with the first digit. For example, if the sum is 2434, and the string is "a" - the result will be a434.
//You will be given a start number, an end number and a string. You have to check all numbers between the start number and the end number (without the end number), do Petar's algorithm and finally replace the digits with the string as described above. 
//Input
//The input data should be read from the console. It consists of three lines:
//•	The first line will hold the starting number;
//•	The second  line will hold the end number;
//•	The third like will hold the replacement string
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//•	The output data must be printed on the console.
//•	On the only output line you must print the result of the game.
//Constraints
//•	Start number and end number will be integers in the range [0 … 18 446 744 073 709 551 615].
//•	The string will contain letters and numbers.
//•	Allowed memory: 16 MB.

//Examples
//Input	Output	Comments
//10
//14
//a	a6	10 + 1 + 2 + 3 = 16. 16 is even 1 will be replaced.  Result is a6

//Input	Output	Input	Output
//10
//99
//as	asas2as
//    234
//3547
//SadPanda	12SadPanda969SadPanda 





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PetarGame
{
    class PetarGame
    {
        static void Main(string[] args)
        {
            ulong startNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());
            string replacementString = Console.ReadLine();
            BigInteger sum = new BigInteger();

            //calculate sum of numbers
            for (ulong i = startNumber; i < endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    ulong mod = i % 5;
                    sum += mod;
                }
            }
            string sumString = sum.ToString();
            string replacedDigit;
            string outputString;
            
            if (sum % 2 == 0)
            {

                replacedDigit = sumString[0].ToString();
               
               
            }
            else
            {
                    replacedDigit = sum.ToString()[sum.ToString().Length - 1].ToString();
                  

                }
            outputString = sumString.Replace(replacedDigit, replacementString);
            Console.Write(outputString);

        }
    }
}
