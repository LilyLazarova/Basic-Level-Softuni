using System;
using System.Numerics;

    class Calculate_combinatoric
    {
        static void Main()
        {
            Console.Write("Please, enter integer number N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter integer number K = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialNminusK = 1;
            BigInteger result = 1; 

            for (int i = k + 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (int j = 1; j <= (n - k); j++)
            {
                factorialNminusK *= j;
            }
            result = factorialN / factorialNminusK;
            Console.WriteLine("n! / (k! * (n-k)!) = {0} ", result);
        }
    }

