//Problem 3 - Sunlight
//Sandy is a little girl who spends her free time playing with her friends. Unfortunately, Sandy broke her wristwatch a week ago. Now she is trying a new trick using the sunlight to guess the time. But this trick is useful only when the sky isn’t cloudy. Your task is to help Sandy by writing a program which shows how bright the sun is at the moment. 
//You are given an integer number N (always odd), corresponding to the width and height of the sun and the length of the horizontal and vertical sunbeams. The diagonal sunbeams have length equal to N – 1.
//Input
//The input data should be read from the console.
//•	On the only input line you will be given an integer N - the size of the sun. 
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. Use the “*” (asterisk) to mark the sun and the sunbeams and “.” (dot) for the rest. Follow the examples below.
//Constraints
//•	N will always be a positive odd number in the range [3 … 33].
//•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

//Examples
//Input	Output		Input	Output
//3	....*....
//.*..*..*.
//..*.*.*..
//...***...
//*********
//...***...
//..*.*.*..
//.*..*..*.
//....*....		5	 .......*.......
// .*.....*.....*.
// ..*....*....*..
// ...*...*...*...
// ....*..*..*....
// .....*****.....
// .....*****.....
// ***************
// .....*****.....
// .....*****.....
// ....*..*..*....
// ...*...*...*...
// ..*....*....*..
// .*.....*.....*.
// .......*.......



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunlight
{
    class Sunlight
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            string dot = new string('.',((3 * N) - 1) / 2);
            Console.WriteLine(dot+'*'+dot);
            
            int dotInside=(3*N-5)/2;
            int dotOutside = 1;
            for (int i = 0; i < N-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}",new string('.',dotOutside),'*',new string('.',dotInside));
                dotOutside++;
                dotInside--;
                
            }
            for (int i = 0; i < (N-1)/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.',N), new string('*',N));
            }

            Console.WriteLine("{0}",new string ('*',3*N));

            for (int i = 0; i < (N - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', N), new string('*', N));
            }

            dotOutside--;
            dotInside++;
            
            for (int i = N-1; i >0 ; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', dotOutside), '*', new string('.', dotInside));
                dotOutside--;
                dotInside++;

            }
            Console.WriteLine(dot + '*' + dot);
            Console.WriteLine();
        }
    }
}
