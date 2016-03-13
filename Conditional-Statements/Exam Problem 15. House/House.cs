//Ivaylo decided he needs a new house. Since he is not a structural engineer yet, you have to help him construct the building from the ground zero.
//The roof is a triangle. The walls are straight vertical lines. The base is a straight horizontal line. The roof, the walls and the base of the house it build of '*'. Everything else is filled with '.' (see the examples below to catch the idea).
//You will be given an odd integer N, representing the width and the height of the house. The roof’s top starts from the center (N+1)/2 and forms a triangle with base of width N. The roof’s height is (N+1)/2. The distance between the roofs’ end point and the walls of the building is N/4, rounded down to an integer number. See the examples below to understand better these formulas.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_15.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            roof(n);
            floor(n);

            
        }
        public static void roof(int n)
        {
            string dotsFirstLine = new string ('.',n/2);
            string star = "*";
            string firstLine = dotsFirstLine + star + dotsFirstLine;
            string endLine = new string('*', n);
            Console.WriteLine(firstLine);


            for (int i =1 ; i < n-2; i+=2)
            {
                
                string dots = new string('.', (((n-i)/2)-1));
                string dotsMiddle = new string('.', i);
                Console.Write(dots);
                Console.Write(star);
                Console.Write(dotsMiddle);
                Console.Write(star);
                Console.WriteLine(dots);
             }

            Console.WriteLine(endLine);
        }
        public static void floor(int n)
        {
            for (int i = 0; i < (n-1)/2 -1 ; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",new string('.',n/4), '*',new string ('.',(n-((n/4)+(n/4)+2))));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 4), new string('*',(n-(n/4)-(n/4))));
        }
    }
}


//==============================================================================================

//Original

//using System;

//public class House
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        Console.Write(new string('.', n / 2));
//        Console.Write(new string('*', 1));
//        Console.WriteLine(new string('.', n / 2));

//        int outsideCounter = n / 2 - 1;
//        int insideCounter = 1;

//        while (outsideCounter != 0)
//        {
//            Console.Write(new string('.', outsideCounter));
//            Console.Write(new string('*', 1));
//            Console.Write(new string('.', insideCounter));
//            Console.Write(new string('*', 1));
//            Console.WriteLine(new string('.', outsideCounter));

//            outsideCounter--;
//            insideCounter += 2;
//        }

//        Console.WriteLine(new string('*', n));

//        int wallDistance = n / 4;

//        for (int i = n / 2 + 1; i < n - 1; i++)
//        {
//            Console.Write(new string('.', wallDistance));
//            Console.Write(new string('*', 1));
//            Console.Write(new string('.', n - 2 * wallDistance - 2));
//            Console.Write(new string('*', 1));
//            Console.WriteLine(new string('.', wallDistance));
//        }

//        Console.Write(new string('.', wallDistance));
//        Console.Write(new string('*', n - 2 * wallDistance));
//        Console.WriteLine(new string('.', wallDistance));
//    }
//}
