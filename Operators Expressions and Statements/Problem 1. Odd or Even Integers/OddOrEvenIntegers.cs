using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter a number to check if it is odd or even:");
            int number = int.Parse(Console.ReadLine());
            int mod = number % 2;
            

            if (mod == 0)
            {
                Console.WriteLine("The number is even!");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }

