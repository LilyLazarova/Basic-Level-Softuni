using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Numbers_from_1_to_N
{
    class NumbersFrom1toN
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersCount; i++)
            {
                Console.Write("{0} ",i);
                
            } Console.WriteLine();
        }
    }
}
