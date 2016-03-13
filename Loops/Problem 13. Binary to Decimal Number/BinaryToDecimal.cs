using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please, enter a binary number n = ");
        string input = Console.ReadLine();
        int digit = 0;
        double digitOnPower = 0;
        long sum = 0L;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            digit = input[i] - '0';

            if (digit == 1)
            {
                digitOnPower = Math.Pow(2, input.Length - i - 1);
                sum += (long)digitOnPower;
            }

        } Console.WriteLine("Decimal number = {0}", sum);

    }
}


