using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            double[] coordinatesA = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] coordinatesB = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] coordinatesC = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] coordinatesD = Console.ReadLine().Split().Select(double.Parse).ToArray();
            
            double r = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());

            //double a = Math.Abs(coordinatesA[0] - coordinatesB[0]);
            //double b = Math.Abs(coordinatesB[1] - coordinatesC[1]);
            int pointNumbers = 0;

            double temp = r;
            
            //if (r > coordinatesB[0] && r> coordinatesC[1])
            //{
            
            //up right
                for (double i = 0; i < coordinatesC[1]; i += step)
                {
                    for (double j = 0; j < temp; j += step)
                    {
                        if (r > coordinatesB[0])
                        {
                           
                            temp = coordinatesB[0];
                            //pointNumbers++;
                        }
                        if (r > coordinatesC[1])
                        {
                            temp = coordinatesC[1];
                            //pointNumbers++;
                        }
                       pointNumbers++;
                    }
                }
                temp = r;

            //Up left
                for (double i = 0; i < coordinatesD[1]; i += step)
                {
                    for (double j = 0; j < temp; j += step)
                    {
                        if (r > coordinatesA[0])
                        {
                            temp = coordinatesA[0];
                            //pointNumbers++;
                        }
                        if (r > coordinatesD[1])
                        {
                            temp = coordinatesD[1];
                           // pointNumbers++;
                        }
                        pointNumbers++;
                    }
                }
                temp = r;

            //down left

                for (double i = 0; i < coordinatesD[0]; i += step)
                {
                    for (double j = 0; j < temp; j += step)
                    {
                        if (r > coordinatesA[1])
                        {
                            temp = coordinatesA[1];
                            //pointNumbers++;
                        }
                        if (r > coordinatesD[0])
                        {
                            temp = coordinatesD[0];
                            //pointNumbers++;
                        }
                        pointNumbers++;
                    }
                }
                temp = r;

            // down right

                for (double i = 0; i < coordinatesC[0]; i += step)
                {
                    for (double j = 0; j < temp; j += step)
                    {
                        if (r > coordinatesB[1])
                        {
                            temp = coordinatesB[1];
                            //pointNumbers++;
                        }
                        if (r > coordinatesC[0])
                        {
                            temp = coordinatesC[0];
                            //pointNumbers++;
                        }
                        pointNumbers++;
                    }
                }

            //}
            //if (r>a/2)  
            //{
            //    for (double i = 0; i < a/2; i += step)
            //    {
            //        for (double j = 0; j < r; j += step)
            //        {
            //            pointNumbers++;
            //        }
            //    }
            //}

            //// up left
            //for (double i = 0; i < r; i += step)
            //{
            //    for (double j = 0; j < b / 2; j += step)
            //    {
            //        pointNumbers++;
            //    }
            //}

            //for (double i = 0; i < r; i += step)
            //{
            //    for (double j = 0; j < b / 2; j += step)
            //    {
            //        pointNumbers++;
            //    }
            //}


            Console.WriteLine(pointNumbers);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
        }
    }
}
