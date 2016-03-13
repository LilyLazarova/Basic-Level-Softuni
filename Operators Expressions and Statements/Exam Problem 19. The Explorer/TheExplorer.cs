using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_19.The_Explorer
{
    class TheExplorer
    {
        static void Main(string[] args)
        {
        
            int n = int.Parse(Console.ReadLine());
            string dashFirstLine = new string('-', n / 2);
            string star = "*";
            string firstLine = dashFirstLine + star + dashFirstLine;

            Console.WriteLine(firstLine);

            for (int i = 1; i <= n / 2; i++)
            {
                string dash = new string('-', (n / 2) - i);
                string dashMiddle = new string('-', (2 * i) - 1);
                string middleRow = "*" + dashMiddle + "*";


                Console.WriteLine(dash + star + dashMiddle + star + dash);

            }
            for (int i = 1; i <n/2 ; i++)
            {
                string dash = new string('-', i);
                string dashMiddle = new string('-', (n-(2*i) - 2));
                Console.WriteLine(dash + star+dashMiddle+star+dash);
            }
            Console.WriteLine(firstLine);
        }
    }
}
