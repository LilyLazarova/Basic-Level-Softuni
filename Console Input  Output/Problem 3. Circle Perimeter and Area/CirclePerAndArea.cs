using System;

    class CirclePerAndArea
    {
        static void Main()
        {
            Console.Write("Please, enter radius of the circle r = ");

            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine("Perimeter = {0:f2}\nArea = {1:f2}",perimeter,area);

            
        }
    }
