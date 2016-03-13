using System;

    class CalculateNfactorialDividedKfactorial
    {
        static void Main()
        {
            Console.Write("Please, enter integer number N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter integer number K = ");
            int k = int.Parse(Console.ReadLine());
            decimal factorialN = 1;
                       
                for (int i = k+1; i <= n; i++)
                {
                    factorialN *= i;

                } Console.WriteLine("n! / k! = {0} ", factorialN);
        }
    }

