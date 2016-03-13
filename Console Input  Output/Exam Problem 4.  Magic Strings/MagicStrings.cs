//NOT COMPLETED


using System;
using System.Linq;

    class MagicStrings
    {
        static void Main()
        {
           
            byte diff = Byte.Parse(Console.ReadLine());
            int weightK = 1;
            int weightN = 4;
            int weightS = 3;
            int weightP = 5;
            int[] firstString = new int[4];
            int[] secondString = new int[4];

            int sum1 = firstString.Sum();
            int sum2 = secondString.Sum();

            if (diff<=16 && diff>=0)                                               //max sum = 4*5=20;min sum = 4*1
            {
                //for (sum1 = 4; sum1 <= 20; sum1++)
                //{
                //    for (sum2 = 4; sum2 <= 20; sum2++)
                //    {
                        for (int firstPosition = 0; firstPosition < 4; firstPosition++)
                        {
                            switch (firstPosition)
                            {
                                case 0: firstString[firstPosition] = weightK;
                                    Console.WriteLine(firstString[firstPosition]);
                                    break;
                                case 1: firstString[firstPosition] = weightS;
                                    Console.WriteLine(firstString[firstPosition]);
                                    break;
                                case 2: firstString[firstPosition] = weightN;
                                    Console.WriteLine(firstString[firstPosition]);
                                    break;
                                case 3: firstString[firstPosition] = weightP;
                                    Console.WriteLine(firstString[firstPosition]);
                                    break;
                            }
                            
                        }
                    }
            //    }
            //}
            else
            {
                Console.WriteLine("No");
            } 
        }
    }

