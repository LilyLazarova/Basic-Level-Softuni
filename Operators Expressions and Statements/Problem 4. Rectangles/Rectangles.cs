using System;

    class Rectangles
    {
        static void Main()
        {
            Console.Write("width:");
            string input1 = Console.ReadLine();
            double width = 0;
            bool isWidthOK = double.TryParse(input1, out width);
            Console.Write("height:");
            string input2 = Console.ReadLine();
            double height = 0;
            bool isHeightOK = double.TryParse(input2, out height);

            double perimeter = (2 * height) + (2 * width);
            double area = width * height;

            if (isWidthOK && isHeightOK && width>=0 && height >=0)
            {
                Console.WriteLine("Perimeter = {0}\nArea = {1}",perimeter, area);
            }
            else
            {
                Console.WriteLine("Enter a valid value!");
            }
        }
    }

