using System;
using System.Linq;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter 4-digit number:");
            int number = int.Parse(Console.ReadLine());
            
            int digitOfOnes = (number % 10);
            int digitOfTens = (number / 10) % 10;
            int digitOfHundreds = (number / 100) % 10;
            int digitOfOneThousands = number/1000;
            int sumOfDigits = digitOfOnes + digitOfTens + digitOfHundreds + digitOfOneThousands;

            int[] elements = Console.ReadLine().ToCharArray().Select(ch => ch - '0').ToArray(); //change every char and convert to digit(ch-'0'-->izvajda 0 ASCII code)
            int sum = elements.Sum();
            Array.Reverse(elements);
            //int[] elementsInt = Array.ConvertAll(elements, int.Parse);

            int sum = elementsInt.Sum();

            if (digitOfOneThousands != 0)
            {
                Console.WriteLine("Sum of digits is: {0}", sumOfDigits);
                //int temp1 = digitOfOnes;
                //digitOfOnes = digitOfOneThousands;
                //digitOfOneThousands = temp1;
                //int temp2 = digitOfTens;
                //digitOfTens = digitOfHundreds;
                //digitOfHundreds = temp2;
                //Console.Write("Reversed number is : {0}{1}{2}{3}", digitOfOneThousands,digitOfHundreds,digitOfTens,digitOfOnes);
                Console.WriteLine("Reversed number is : {0}{1}{2}{3}", digitOfOnes,digitOfTens,digitOfHundreds,digitOfOneThousands);
                Console.WriteLine("Last digit on first position:{0}{1}{2}{3} ",digitOfOnes,digitOfOneThousands,digitOfHundreds,digitOfTens);
                Console.WriteLine("Second and third digits exchanged:{0}{1}{2}{3}",digitOfOneThousands,digitOfTens,digitOfHundreds,digitOfOnes);
            }
            else
            {
                Console.WriteLine("Number should not start with 0, please enter a new one!");
            }
           
        }

    }
