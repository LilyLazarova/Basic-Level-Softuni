using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Please, enter an integer to calculate the n-th Catalan number n = ");
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial2N = 1;
            BigInteger factorialNplus1 = 1;
            BigInteger catalanNumber = 1;

            for (int i = n+1; i <= 2*n; i++)
            {
                factorial2N *= i;
            }
            for (int i = 1; i <= n+1; i++)
            {
                factorialNplus1 *= i;
            }
            catalanNumber = factorial2N / factorialNplus1;
            Console.WriteLine("((2n)!/n!(n+1)!) = {0}",catalanNumber);
        }
    }

