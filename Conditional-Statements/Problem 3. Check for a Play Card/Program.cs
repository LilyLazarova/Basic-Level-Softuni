//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter card sign to check: ");
            string cardSign = Console.ReadLine();
            byte cardSignDigits;
            bool isCardSignDigit = byte.TryParse(cardSign, out cardSignDigits);

            if (isCardSignDigit && cardSignDigits >=2 && cardSignDigits<=10)
            {
                Console.WriteLine("YES");
            }
            else if (cardSign.Equals("J") || cardSign.Equals("Q")|| cardSign.Equals("K")|| cardSign.Equals("A"))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }         
        }
    }

