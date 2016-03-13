using System;

    class PointInsideCircleOutiseRect
    {
        static void Main()
        {
            Console.Write("Enter x coordinate of the point: ");
            double x;
            bool isXdouble = double.TryParse(Console.ReadLine(), out x);
            Console.Write("Enter y coordinate of the point: ");
            double y;
            bool isYdouble = double.TryParse(Console.ReadLine(),out y);
            double distanceFromCenterToPoint = Math.Sqrt(((x-1) * (x-1)) + ((y-1) * (y-1)));

            if (isXdouble && isYdouble)
            {
                if (-0.5<=x && x<=2.5 && 1 <y && y<=2.5 && distanceFromCenterToPoint <= 1.5)
                {
                    Console.WriteLine("Is point inside the circle K\\{(1,1);1.5)\\}: true");
                }
                else
                {
                    Console.WriteLine("Is point inside the circle K\\{(1,1);1.5)\\}: false");
                }
            }
            else
            {
                Console.WriteLine("Please, enter a valid coordinates!");
            }
        
        }
    }

