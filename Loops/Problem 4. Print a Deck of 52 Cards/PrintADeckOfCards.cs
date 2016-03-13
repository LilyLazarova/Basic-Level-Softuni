using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Print_a_Deck_of_52_Cards
{
    class PrintADeckOfCards
    {
        static void Main(string[] args)
        {


            char spade = '\u2663';
            char diamond = '\u2666';
            char heart = '\u2665';
            char club = '\u2660';
        
            for (int i = 2; i < 11; i++)
            {
                Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}",i,spade,diamond,heart,club);
            }

            for (int j = 0; j < 4; j++)
            {
                //char cardNumber = (char)j;
                char J = 'J';
                char Q = 'Q';
                char K = 'K';
                char A = 'A';
                switch (j)
                {
                    case 0: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}",J, spade, diamond, heart, club); break;
                    case 1: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", Q, spade, diamond, heart, club); break;
                    case 2: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", K, spade, diamond, heart, club); break;
                    case 3: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", A, spade, diamond, heart, club); break;

                    default:
                        break;

                }
            }
            }
        }
    }

