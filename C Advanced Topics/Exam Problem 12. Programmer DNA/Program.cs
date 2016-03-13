using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_12.Programmer_DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNAsize = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());

            char[] matrixL = new char[DNAsize];

            for (int i = 0; i < 7; i++)
            {
                if (letter == 'H')
                {
                    letter = 'A';
                }
                matrixL[i] = letter;
                letter++;
            }

            char[,] matrix = new char[7, 7] {         {'.', '.', '.', matrixL[0], '.', '.', '.'},
                                               {'.', '.', matrixL[1], matrixL[2], matrixL[3], '.', '.'},
                                           {'.', matrixL[4], matrixL[5], matrixL[6], matrixL[0], matrixL[1], '.'},
                                               {matrixL[2], matrixL[3],matrixL[4], matrixL[5], matrixL[6], matrixL[0], matrixL[1]},
                                               {'.', matrixL[2], matrixL[3], matrixL[4], matrixL[5], matrixL[6], '.'},
                                               {'.', '.', matrixL[0], matrixL[1], matrixL[2], '.', '.'},
                                               {'.', '.', '.', matrixL[3], '.', '.', '.'}

            };


            //for (int i = 0; i < length; i++)
            //{
                
            //}

            //Printing array

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                   Console.Write(matrix[i,j]);
                } 
                Console.WriteLine();
            }
            
            //for (int i = 0; i <= 3; i++)
            //{
            //    string dot = new string('.', 3 - i);
            //    Console.Write(dot);
            //    if (letter == 'H')
            //    {
            //        letter = 'A';
            //    }
            //    Console.Write(letter);
            //    for (int j = 1; j < 2*i+1; j++)
            //    {
            //        letter++;
            //        if (letter=='H')
            //        {
            //            letter = 'A';
            //        }
            //        Console.Write(letter);
            //    }
            //    Console.WriteLine(dot);
            //    letter++;
                
            //}

        }
       
        }
    }
