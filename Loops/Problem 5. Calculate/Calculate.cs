using System;

    class Calculate
    {
        static void Main()
        {
            Console.Write("Please, enter an integer number N = ");
            int numberN = int.Parse(Console.ReadLine());
            Console.Write("Please, enter an integer number X = ");
            int numberX = int.Parse(Console.ReadLine());
            decimal factorial = 1; 
            decimal divider = 1;
            decimal sum = 1;

            for (int i = 1; i <= numberN ; i++)
            {
                factorial *= i;
                divider = (decimal)Math.Pow(numberX, i);
                sum += (factorial / divider);
            }
            Console.WriteLine("Sum = {0:f5}", sum);
        }
    }

