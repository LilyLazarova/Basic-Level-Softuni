//You are given a two-dimensional Cartesian coordinate system and three points A, B, C with coordinates: A(Ax, Ay), B(Bx,  By), C(Cx, Cy). Write a program to check if these three points can form a triangle. Then calculate the area of this triangle. To find the distance between two points with the coordinates (x1, y1) and (x2, y2) use the formula:
//D= √(〖〖(x〗_2-x_1)〗^2+〖〖(y〗_2-y_1)〗^2 )  
//You can use the inequalities of a triangle to check whether three segments a, b and c can form a triangle:
//a+b>c;  b+c>a; a+c>b
//To calculate the area you can use Heron`s formula (a method for calculating the area of a triangle when you know the lengths of all three sides). Let a, b, c be the lengths of the sides of a triangle. Thus:
//Area=√(p(p-a)(p-b)(p-c) ), where p is half the perimeter: (a+b+c)/2.
//Input
//The input data comes from the console. It consists of exactly 6 lines holding the coordinates of the three points: Ax-coordinate, Ay-coordinate, Bx-coordinate, By-coordinate, Cx-coordinate and Cy-coordinate. The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console and must contain two lines. 
//    First line: If the given points can form a triangle you must print the message “Yes”, otherwise “No”.
//    Second line: If the given points can form a triangle you must print the area of the triangle rounded to two decimal places (see the examples), otherwise you must print the distance between point A and point B. Use "." as decimal separator.
//Constraints
//    The coordinate X is integer in the range [-10000… 10000] inclusive.
//    The coordinate Y is integer in the range [-10000… 10000] inclusive.
//    Allowed work time for your program: 0.1 seconds.
//    Allowed memory: 16 MB.
//Examples
//Input	Output	Comments		Input	Output	Comments
//2
//2
//0
//0
//1
//1	No
//2.83
//            2
//3
//0
//-1
//4
//-2	Yes
//9.00	 




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_13.Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            double ax = double.Parse(Console.ReadLine());
            double ay = double.Parse(Console.ReadLine());
            double bx = double.Parse(Console.ReadLine());
            double by = double.Parse(Console.ReadLine());
            double cx = double.Parse(Console.ReadLine());
            double cy = double.Parse(Console.ReadLine());
            
            double a = Math.Sqrt((((bx-ax)*(bx-ax))+((by-ay)*(by-ay))));
            double b = Math.Sqrt((((cx-bx)*(cx-bx))+((cy-by)*(cy-by))));
            double c = Math.Sqrt((((ax - cx) * (ax - cx)) + ((ay - cy) * (ay - cy))));

            double halfPerimeter = (a + b + c) / 2;
            double Area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            if ((a+b)>c && (b+c)>a && (a+c)>b)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0:F2}",Area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}",a);
            }
        }
    }
}
