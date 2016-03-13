using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int height = (int)(Math.Floor(N * 1.5));

            if (height%3==0)
            {
                for (int i = 0; i < height / 3; i++)
                {
                    FirstLine(N);
                    Console.WriteLine();
                    SecondLine(N);
                    Console.WriteLine();
                    ThirdLine(N);
                    Console.WriteLine();
                }
            }
            if (height%3==1)
            {
                for (int i = 0; i < height/3; i++)
            {
                FirstLine(N);
                Console.WriteLine();
                SecondLine(N);
                Console.WriteLine();
                ThirdLine(N);
                Console.WriteLine();
            }
                FirstLine(N);
                Console.WriteLine();
            }
            if (height % 3 == 2)
            {
                for (int i = 0; i < height / 3; i++)
                {
                    FirstLine(N);
                    Console.WriteLine();
                    SecondLine(N);
                    Console.WriteLine();
                    ThirdLine(N);
                    Console.WriteLine();
                }
                FirstLine(N);
                Console.WriteLine();
                SecondLine(N);
                Console.WriteLine();
            }
         




        }

        public static void FirstLine(int N)
        {
            string pattern = "#..";

            if (N % 3 == 0)
                for (int i = 0; i < N / 3; i++)
                {
                    Console.Write(pattern);

                }
            //Console.WriteLine();
            if (N % 3 == 1)
            {
                for (int i = 0; i < N / 3; i++)
                {
                    Console.Write(pattern);
                }
                Console.Write("#");
                //Console.WriteLine();
            } if (N % 3 == 2)
            {
                for (int i = 0; i < N / 3; i++)
                {
                    Console.Write(pattern);


                }
                Console.Write("#");
                Console.Write(".");
                //Console.WriteLine();
            }
        }
        public static void SecondLine(int N)
        {
            string pattern = "..#";

            if (N % 3 == 0)
                for (int i = 0; i < N / 3; i++)
                {
                    Console.Write(pattern);

                }
            //Console.WriteLine();
            if (N % 3 == 1)
            {
                for (int i = 0; i < N / 3; i++)
                {
                    Console.Write(pattern);


                }
                Console.Write(".");
               // Console.WriteLine();
            } if (N % 3 == 2)
            {
                for (int i = 0; i < N / 3; i++)
                {
                    Console.Write(pattern);


                }
                Console.Write(".");
                Console.Write(".");
               // Console.WriteLine();
            }
        }

        public static void ThirdLine(int N)
        {
            string pattern = ".#.";

            if (N % 3 == 0)
                for (int i = 0; i < N / 3; i++)
                {
                    Console.Write(pattern);

                }
            //Console.WriteLine();
            if (N % 3 == 1)
            {
                for (int i = 0; i < N / 3; i++)
                {
                    Console.Write(pattern);


                }
                Console.Write(".");
                // Console.WriteLine();
            } if (N % 3 == 2)
            {
                for (int i = 0; i < N / 3; i++)
                {
                    Console.Write(pattern);


                }
                Console.Write(".");
                Console.Write("#");
                // Console.WriteLine();
            }
        }
    }
}