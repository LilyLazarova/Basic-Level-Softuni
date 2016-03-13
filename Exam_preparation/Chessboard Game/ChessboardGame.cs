//Goshko is a keen chess player. One day he was bored with his work and decided to take a break and create a game using the chessboard. He takes a string, e.g. "Software University_2345", converts its symbols to numbers through their ASCII codes and fills a chessboard with them. He takes the values of capital and small letters and digits only. The value of any other symbol is zero. He fills the board’s squares with the numbers, from left to right and from top to bottom (see the example below). The size of the chessboard is n*n (e.g. n = 5) and it always starts with a black square. N will always be an odd number.
//S	o	f	t	w		83	111	102	116	119
//a	r	e		U		97	114	101	0	85
//n	i	v	e	r		110	105	118	101	114
//s	i	t	y	_		115	105	116	121	0
//2	3	4	5			50	51	52	53	0


//Let’s assume that there are two competing teams: the black team and the white team. Every team’s score is the sum of the values in its squares. However if a square contains a capital letter its value should be given to the opposing team. In the example above the scores are calculated as follows:
//White Team Score = 83 'S' + 111 'o' + 116 't' + 97 'a' + 101 'e' + 105 'i' + 101 'e' + 115 's' + 116 't' + 51 '3' + 53 '5' = 1049
//Black Team Score = 102 'f' + 119 'w' + 114 'r' + 85 'U' + 110 'n' + 118 'v' + 114 'r' + 105 'i' + 121 'y' + 50 '2' + 52 '4' = 1090.
//Input
//The input data should be read from the console.
//•	The first line holds the size n of the chessboard.
//•	The second line holds the input string.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//•	The first output line holds the winning team in format: “The winner is: {name} team”.
//•	The second line holds the difference between the scores of the winning and the losing team. 
//•	In case the score is equal, print “Equal result: {points}”. Do not print the difference in this case!
//Constraints
//•	The number n will be an odd integer in the range [1 … 9].
//•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
//Examples
//Input	Output
//5
//Software University_2345	The winner is: black team
//41

//Input	Output
//3
//aa	Equal result: 97



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard_Game
{
    class ChessboardGame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            
            int currentPosition=-1;
            int sumBlack = 0;
            int sumWhite = 0;
            int length = input.Length;
            int[,] board = new int[size, size];

            int i = 0; 
            int j = 0;
            
            do
            {
                currentPosition++;

                if ((input[currentPosition] >= 48 && input[currentPosition] <= 57) ||
                    (input[currentPosition] >= 65 && input[currentPosition] <= 90) ||
                    (input[currentPosition] >= 97 && input[currentPosition] <= 122))
                {
                    board[i, j] = input[currentPosition];
                    if (currentPosition % 2 == 0 && !(input[currentPosition] >= 65 && input[currentPosition] <= 90))       
                    {
                        sumBlack += board[i, j];
                    }
                    if (currentPosition % 2 != 0 && !(input[currentPosition] >= 65 && input[currentPosition] <= 90))
                    {
                        sumWhite += board[i, j];
                    }
                    if (currentPosition % 2 == 0 && (input[currentPosition] >= 65 && input[currentPosition] <= 90))
                    {
                        sumWhite += board[i, j];
                    }
                    if (currentPosition % 2 != 0 && (input[currentPosition] >= 65 && input[currentPosition] <= 90))
                    {
                        sumBlack += board[i, j];
                    }

                }
                else
                {
                    board[i, j] = 0;
                }
                i++;
                if (i == size)
                {
                    i = 0;
                    j++;
                }
            }
            while ((currentPosition < (size * size - 1)) && (currentPosition < length-1)); 
            
            if (sumBlack>sumWhite)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine("{0}",Math.Abs(sumBlack-sumWhite));
            }
            else if(sumWhite>sumBlack)
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine("{0}", Math.Abs(sumBlack - sumWhite));
            }
            else
            {
                Console.WriteLine("Equal result: {0}",sumWhite);
            }
          
        }
    }
}


//==================================================================================================

//using System;

//public class ChessboardGame
//{
//    public static void Main()
//    {
//        int sizeOfMatrix = int.Parse(Console.ReadLine());

//        string input = Console.ReadLine();

//        int blackScore = 0;
//        int whiteScore = 0;

//        for (int i = 0; i < input.Length; i++)
//        {
//            if (i >= sizeOfMatrix * sizeOfMatrix)
//            {
//                break;
//            }

//            if (i % 2 == 0 && char.IsUpper(input[i]))
//            {
//                whiteScore += input[i];
//            }
//            else if (i % 2 == 0 && char.IsLetterOrDigit(input[i]))
//            {
//                blackScore += input[i];
//            }
//            else if (i % 2 != 0 && char.IsUpper(input[i]))
//            {
//                blackScore += input[i];
//            }
//            else if (i % 2 != 0 && char.IsLetterOrDigit(input[i]))
//            {
//                whiteScore += input[i];
//            }
//        }

//        if (blackScore == whiteScore)
//        {
//            Console.WriteLine("Equal result: {0}", whiteScore);
//        }
//        else
//        {
//            Console.WriteLine(
//                "The winner is: {0} team", 
//                whiteScore > blackScore ? "white" : "black");

//            int resultDifference = Math.Abs(whiteScore - blackScore);
//            Console.WriteLine(resultDifference);
//        }
//    }
//}