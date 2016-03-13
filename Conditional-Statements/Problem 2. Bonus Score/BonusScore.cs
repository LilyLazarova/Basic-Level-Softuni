﻿//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//•	If the score is between 1 and 3, the program multiplies it by 10.
//•	If the score is between 4 and 6, the program multiplies it by 100.
//•	If the score is between 7 and 9, the program multiplies it by 1000.
//•	If the score is 0 or more than 9, the program prints “invalid score”.


using System;
using System.Linq;

    class BonusScore
    {
        static void Main()
        {
            
            Console.Write("Please, enter you score : ");
            int score = int.Parse(Console.ReadLine());
            
           if (score>=1 && score<=3 )
                {
                    int points = score * 10;
                    Console.WriteLine("Your points are : {0}", points);
                }
                else if (score>=4 && score <=6)
                {
                    int points = score * 100;
                    Console.WriteLine("Your points are : {0}", points);
                }
                else if (score>=7 && score <=9)
                {
                    int points = score * 1000;
                    Console.WriteLine("Your points are : {0}", points);
                }
           else
           {
               Console.WriteLine("Invalid score!");
           }
        }
    }
