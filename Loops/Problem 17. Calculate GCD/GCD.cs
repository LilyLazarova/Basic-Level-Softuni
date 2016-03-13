using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17.Calculate_GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            int a,b;
            int result = 0;
            
            Console.Write("Enter a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            b = int.Parse(Console.ReadLine());
            
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a==0||b==0)
            {
                Console.WriteLine("You have entered zero divider!");
                return;
            }
            else if (a==b)
            {
                result = a;
            }
            else
            {
                do
                {
                    if (a > b)
                    {
                        a = a - b;
                        result = a;
                    }
                    else
                    {
                        b =b - a;
                        result = b;
                    }
                } while (a != b);
            }
            Console.WriteLine("GCD = {0}",result);
        }
    }
}
