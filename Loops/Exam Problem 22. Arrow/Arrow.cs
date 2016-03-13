//SoftUni has opened a new training center in Kaspichan, but the people there did not know how to find it. Your task is to print a vertical arrow, which will be used to indicate the path to the new building in the city. This will help thousands of people to become software engineers. Please help them!
//Input
//The input data should be read from the console.
//•	On the only line will hold and integer number N (always odd number), indicating the width of the arrow. 
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. Use the “#” (number sign) to mark the arrow and “.” (dot) for the rest. Follow the examples below.
//Constraints
//•	N will always be a positive odd number between 3 and 79 inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input	Output		Input	Output		Input	Output
//5
//..#####..
//..#...#..
//..#...#..
//..#...#..
//###...###
//.#.....#.
//..#...#..
//...#.#...
//....#....		
//9
//....#########....
//....#.......#....
//....#.......#....
//....#.......#....
//....#.......#....
//....#.......#....
//....#.......#....
//....#.......#....
//#####.......#####
//.#.............#.
//..#...........#..
//...#.........#...
//....#.......#....
//.....#.....#.....
//......#...#......
//.......#.#.......
//........#........		
//3
//.###.
//.#.#.
//##.##
//.#.#.
//..#..



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_22.Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N >= 3 && N <= 79)
            {
                FirstLine(N);
                MiddlePart(N);
                MiddleLine(N);
                BottomPart(N);

            }

        }
        public static void FirstLine(int N)
        {
            string firstLineDotPart = new string('.', (N - 1) / 2);
            string firstLineHashPart = new string('#', N);
            string firstLine = firstLineDotPart + firstLineHashPart + firstLineDotPart;
            Console.WriteLine(firstLine);
        }

        public static void MiddlePart(int N)
        {
            string firstDotPart = new string('.', (N - 1) / 2);
            string middleDotPart = new string('.', N - 2);
            string middlePart = firstDotPart + "#" + middleDotPart + "#" + firstDotPart;

            for (int i = 0; i < N - 2; i++)
            {
                Console.WriteLine(middlePart);
            }

        }

        public static void MiddleLine(int N)
        {
            string hashPart = new string('#', (N + 1) / 2);
            string dotPart = new string('.', N - 2);
            string middleLine = hashPart + dotPart + hashPart;

            Console.WriteLine(middleLine);
        }

        public static void BottomPart(int N)
        {
            string lastLineDot = new string('.', N - 1);
            string lastLine = lastLineDot + "#" + lastLineDot;

            for (int i = 1; i < N - 1; i++)
            {
                string dotOutsidePart = new string('.', i);
                string dotInsidePart = new string('.', (2*N -1)-((2*i)+2));
                Console.WriteLine(dotOutsidePart + "#" + dotInsidePart + "#" + dotOutsidePart);
                
            }
            Console.WriteLine(lastLine);
            }
        }
    }

//==============================================================================

//using System;

//public class Arrow
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        // Top
//        string top =
//            new string('.', (n - 1) / 2) +
//            new string('#', n) +
//            new string('.', (n - 1) / 2);
//        Console.WriteLine(top);

//        // Top-Middle
//        string topMiddle =
//            new string('.', (n - 1) / 2) + "#" +
//            new string('.', n - 2) + "#" +
//            new string('.', (n - 1) / 2);
//        for (int i = 0; i < n - 2; i++)
//        {
//            Console.WriteLine(topMiddle);
//        }

//        // Middle
//        string middle =
//            new string('#', (n + 1) / 2) +
//            new string('.', n - 2) +
//            new string('#', (n + 1) / 2);
//        Console.WriteLine(middle);

//        // Middle-Bottom
//        int outerDots = 1;
//        int innerDots = 2 * n - 5;
//        for (int i = 0; i < n - 2; i++)
//        {
//            string middleBottom =
//                new string('.', outerDots) + "#" +
//                new string('.', innerDots) + "#" +
//                new string('.', outerDots);
//            Console.WriteLine(middleBottom);
//            outerDots += 1;
//            innerDots -= 2;
//        }

//        // Bottom
//        string bottom =
//            new string('.', outerDots) + "#" +
//            new string('.', outerDots);
//        Console.WriteLine(bottom);
//    }
//}
