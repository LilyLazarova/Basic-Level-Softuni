//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. Examples:
//a	b	c	result
//5	2	2	+
//-2	-2	1	+
//-2	4	3	-
//0	-2.5	4	0
//-1	-0.5	-5.1	-


using System;
using System.Collections.Generic;

    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Please, enter 3 numbers below.");
            double[] allNumbers = new double[3];                                     
                                                                    
            int counter = 0;

            
            for (int i = 0; i < allNumbers.Length; i++)
            {
                allNumbers[i] = double.Parse(Console.ReadLine());
                //int currentNumber = int.Parse(allNumbers[i]);

                if (allNumbers[i] <0)
                {
                    counter++;
                }
            } 
            if (allNumbers[0] == 0 || allNumbers[1]==0 ||allNumbers[2]==0)
            {
                Console.WriteLine("Product is \" 0 \"");
            }
            else if (counter % 2 == 1)
            {
                Console.WriteLine("Product is \" - \"");
            }
            else
            {
                Console.WriteLine("Product is \" + \"");
            }
        }
    }

