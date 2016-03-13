//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that repeating the same subset several times is not a problem. Examples:
//numbers	result
//3  -2  1  1 8	-2 + 1 + 1 = 0
//3 1 -7 35 22	no zero subset
//1 3 -4 -2 -1	1 + -1 = 0
//1 + 3 + -4 = 0
//3 + -2 + -1 = 0
//1 1 1 -1 -1	1 + -1 = 0
//1 + 1 + -1 + -1 = 0
//1 + -1 + 1 + -1 = 0
//…
//0 0 0 0 0	0 + 0 + 0 + 0 + 0 = 0
//Hint: you may check for zero each of the 32 subsets with 32 if statements.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Zero_Subset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {
        }
    }
}
