using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Enter first number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number b = ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Greater number is : {0}", Math.Max(a,b));
        }
    }

