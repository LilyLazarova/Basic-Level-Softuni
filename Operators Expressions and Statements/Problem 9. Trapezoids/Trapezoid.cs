using System;

    class Trapezoid
    {
        static void Main()
        {
            Console.Write("a = ");
            double a;
            bool isAdouble = double.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            double b;
            bool isBdouble = double.TryParse(Console.ReadLine(), out b);
            Console.Write("h = ");
            double h;
            bool isHdouble = double.TryParse(Console.ReadLine(), out h);

            double area = ((a + b) * h) / 2;

            if (isAdouble && isBdouble && isHdouble && a>0 && b>0 && h>0)
            {
                Console.WriteLine("Trapezoid area is : {0}",area);
            }
            else
            {
                Console.WriteLine("Please, enter valid parameters!");
            }
        }
    }

