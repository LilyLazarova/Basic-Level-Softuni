//Once upon a time there was a kingdom and everyone in the kingdom was a thief. Izzy wanted to become the King of Thieves and so started stealing only perfect gems from other thieves. Help Izzy by showing him what a perfect gem with given parameters should look like.
//Input
//The input data should be read from the console. 
//•	The first line will hold the size of the gem – n.
//•	The second line will hold the type of the gem – a symbol: e.g. ‘*’.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. It should consist of ‘n’ lines, holding the gem.
//Constraints
//•	The number n will be a positive odd integer between 3 and 59, inclusive.
//•	The type of the gem will be a symbol from the standard ASCII table.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

//Examples
//Input	Output		Input	Output		Input	Output
//5
//*	--*--
//-***-
//*****
//-***-
//--*--		7
//@	---@---
//--@@@--
//-@@@@@-
//@@@@@@@
//-@@@@@-
//--@@@--
//---@---		13
//a	------a------
//-----aaa-----
//----aaaaa----
//---aaaaaaa---
//--aaaaaaaaa--
//-aaaaaaaaaaa-
//aaaaaaaaaaaaa
//-aaaaaaaaaaa-
//--aaaaaaaaa--
//---aaaaaaa---
//----aaaaa----
//-----aaa-----
//------a------










using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_of_Thieves
{
    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            int dash = N/2;
            int symbolCount =1;

            for (int i = 0; i < (N+1)/2; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string('-',dash),new string(symbol,symbolCount));
                dash--;
                symbolCount += 2;

            }
            dash = 1;
            symbolCount = N - 2;

            for (int i=0; i<(N/2); i++)
            {
 
                Console.WriteLine("{0}{1}{0}", new string('-', dash), new string(symbol, symbolCount));
                dash++;
                symbolCount -= 2;

            }
        }
    }
}
