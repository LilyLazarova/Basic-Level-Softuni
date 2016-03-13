using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Enter a positive integer number in interval [0,100]:");
            int number;
            bool isNumberInt = int.TryParse(Console.ReadLine(), out number);
            int counter=0;

            if (isNumberInt && 0 <= number && number <= 100)
            {
                for (int i = 2; i < number; i++)
                {
                    int mod = number % i;
                    if (number != i && mod != 0)
                    {
                        counter++;
                    }
                } if (counter == (number-2))
                {
                    Console.WriteLine("Number {0} is prime!",number);
                }
                else
                {
                    Console.WriteLine("Number {0} is NOT prime!",number);
                }
            }
            else
            {
                Console.WriteLine("Please, enter an integer number in interval [0,100]!");
            }
        }
    }

