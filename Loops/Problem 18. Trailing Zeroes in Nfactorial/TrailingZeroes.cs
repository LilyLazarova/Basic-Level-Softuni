using System;
using System.Numerics;

    class TrailingZeroes
    {
        static void Main(string[] args)
        {
           Console.Write("Enter an integer number N to calculate trailing zeros in N! : ");
           BigInteger number = int.Parse(Console.ReadLine());
           BigInteger numberFactorial =1;
           BigInteger mod=0;
           int counter = 0;

           for (int i = 1; i <= (int)number; i++)
           {
               numberFactorial *= i;
           } 

            while (mod ==0)
               {
                   mod=numberFactorial % 10;
                   numberFactorial = numberFactorial / 10;
                   if (mod==0)
                   {
                       counter++;
                   }
               } Console.WriteLine("Number of zeros in the end of N! = {0}",counter);
        }
    }

