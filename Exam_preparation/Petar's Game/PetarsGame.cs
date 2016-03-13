using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Petar_s_Game
{
    class PetarsGame
    {
        static void Main(string[] args)
        {
            ulong startNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());
            string replacementString = Console.ReadLine();
            BigInteger sum = new BigInteger();

            string sumString = sum.ToString();


            //calculate sum of numbers
            for (ulong i = startNumber; i < endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    ulong mod = i % 5;
                    sum += mod;
                }
            }

            string replacedDigit;
            if (sum % 2 == 0)
            {
                for (int i = 0; i < sumString.Length; i++)
                {

                    replacedDigit = sum.ToString()[0].ToString();
                    replacedDigit = replacementString;

                    if (sumString[i].Equals(replacedDigit))
                    {
                        string newString = sumString[i].ToString();
                        newString = replacementString;
                    }
                }

            }
            else
            {
                for (int i = 0; i < sumString.Length; i++)
                {
                    replacedDigit = sum.ToString()[sum.ToString().Length - 1].ToString();
                    replacedDigit = replacementString;

                    if (sumString[i].Equals(replacedDigit))
                    {
                        string newString = sumString[i].ToString();
                        newString = replacementString;
                    }
                }
            }
            Console.WriteLine(sumString);

        }
    }
}
