using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Summertime_for_Programmers
{
    class SummertimeForProgrammers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string emptySpace = new string(' ',(N-1)/2);
            string star = new string('*', N + 1);
            string firstLine = emptySpace + star + emptySpace;
            string bottom = new string('*', 2 * N);




            Console.WriteLine(firstLine);
            PrintBottleUpside(N);
            PrintBottleNeck(N);
            PrintEmptyPart(N);
            PrintFullPart(N);
            Console.WriteLine(bottom);


        }

        static void PrintBottleUpside(int N)
        {
            string emptySpaceOutside = new string(' ', (N - 1) / 2);
            string star = "*";
            string emptySpaceInside = new string(' ', N - 1);

            for (int i = 0; i < (N+1)/2; i++)
            {
                
                Console.WriteLine(emptySpaceOutside+star+emptySpaceInside+star+emptySpaceOutside);
            }
            
        }
        static void PrintBottleNeck(int N)
        {
            string emptySpaceOutside;
            string star = "*";
            string emptySpaceInside;
            
            for (int i =0 ; i <(N-3)/2 ; i++)
            {
                emptySpaceOutside = new string(' ', ((N-3)/2)-i);
                emptySpaceInside = new string(' ', (N + 1)+(2*i));
                Console.WriteLine(emptySpaceOutside+star+emptySpaceInside+star+emptySpaceOutside);
                
            }

        }
        static void PrintEmptyPart(int N)
        {
            string star = "*";
            string dots = new string('.', 2 * N - 2);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(star+dots+star);
            }
        }

        static void PrintFullPart(int N)
        {
            string star = "*";
            string cliomba = new string('@', 2 * N - 2);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(star + cliomba + star);
            }
        }

        
    }
}


//====================================================================================

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Summertime
//{
//    class Summertime
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());

//            int space = n / 2;
//            int star = n + 1;
//            int innerSpace = n - 1;
//            int dot = 2 * n - 2;
//            int lambda = 2 * n - 2;
//            Console.WriteLine("{0}{1}{0}", new string(' ', space), new string('*', star));
//            for (int i = 0; i < n / 2; i++)
//            {
//                Console.WriteLine("{0}*{1}*{0}", new string(' ', space), new string(' ', innerSpace));
//            }
//            for (int i = 0; i < n / 2; i++)
//            {
//                Console.WriteLine("{0}*{1}*{0}", new string(' ', space), new string(' ', innerSpace));
//                space--;
//                innerSpace += 2;
//            }
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("*{0}*", new string('.', dot));
//            }

//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("*{0}*", new string('@', lambda));
//            }
//            Console.WriteLine("{0}", new string('*', 2 * n));
//        }
//    }
//}