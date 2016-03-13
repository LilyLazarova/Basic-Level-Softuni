// If 'long' data type is used the program doesn't work correctly for n > 93, because long data type is not enough to be used for such a big numbers.
// ulong doesn't get the correct result
// Adding assembly reference to System.Numerics.dll and use BigInteger(YourProject-->Add Reference-->search for System.Numerics)

using System;
using System.Numerics;


class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter the number of the members of Fibonacci sequence n = ");
        int n;
        bool isNInteger = int.TryParse(Console.ReadLine(), out n);

        if (isNInteger)
        {
            BigInteger numberNMinusOne = 1;
            BigInteger numberNMinusTwo = 0;
            BigInteger sum = numberNMinusOne + numberNMinusTwo;

            Console.WriteLine(numberNMinusTwo);
            Console.WriteLine(numberNMinusOne);

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(sum);
                numberNMinusTwo = numberNMinusOne;
                numberNMinusOne = sum;
                sum = numberNMinusOne+numberNMinusTwo;
            }
            
        }
        else
        {
            Console.WriteLine("Please, enter an integer number!");
        }
    }
}
