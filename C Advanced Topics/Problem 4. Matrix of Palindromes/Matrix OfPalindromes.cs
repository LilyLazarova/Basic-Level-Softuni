using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Matrix_of_Palindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the dimention of matrix!");
            Console.Write("rows = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("columns = ");
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];
            char[] palindrome = new char[3];

            if (rows+cols<28)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        palindrome[0] = (char)(i + 97);             //97 is the ASCI code of 'a'
                        palindrome[1] = (char)(j + i + 97);
                        palindrome[2] = palindrome[0];


                        for (int k = 0; k < 3; k++)
                        {
                            Console.Write(palindrome[k]);
                        }
                        Console.Write(" ");
                    } Console.WriteLine();

                }
            }
            else
            {
                Console.WriteLine("Please enter dimention in interval maxSum of rows+cols = 27");
            }
            
        }
    }
}
