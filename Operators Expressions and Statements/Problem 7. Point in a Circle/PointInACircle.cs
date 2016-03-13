using System;

    class PointInACircle
    {
        static void Main()
        {
            Console.Write("Enter x coordinate of the point: ");
            double x;
            bool isXdouble = double.TryParse(Console.ReadLine(), out x);
            Console.Write("Enter y coordinate of the point: ");
            double y;
            bool isYdouble = double.TryParse(Console.ReadLine(),out y);
            double distanceFromCenterToPoint = Math.Sqrt((x * x) + (y * y));

            if (isXdouble && isYdouble)
            {
                if (-2<=x && x<=2 && -2 <=y && y<=2 && distanceFromCenterToPoint <= 2)
                {
                    Console.WriteLine("Is point inside the circle K\\{(0,0);2)\\}: true");
                }
                else
                {
                    Console.WriteLine("Is point inside the circle K\\{(0,0);2)\\}: false");
                }
            }
            else
            {
                Console.WriteLine("Please, enter a valid coordinates!");
            }
        }
    }

