//Write a program that finds the biggest of five numbers by using only five if statements. Examples:

using System;

    class TheBiggestOf5Numbers
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());

            double max = double.MinValue;

            if (a>=max)
            {
                max = a;
            } 
            if (b>=max)
            {
                max = b;
            }
            if (c>=max)
            {
                max = c;
            }
            if (d>=max)
            {
                max = d;
            }
            if (e>=max)
            {
                max = e;
            } Console.WriteLine("Max number is : {0}",max);
        }
    }

