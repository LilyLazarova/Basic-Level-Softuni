using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Problem1
    {
        static void Main(string[] args)
        {
            double weight = (int.Parse(Console.ReadLine()))/2.2;
            double height = (int.Parse(Console.ReadLine()))*2.54;
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int workouts = int.Parse(Console.ReadLine());
            double dci = 0;

            double BMRMen = 66.5+(13.75*weight)+ (5.003*height)-(6.755*age);
            double BMRWomen = 655 + (9.563 * weight) + (1.850 * height) - (4.676 * age);

            if (workouts<=0)
            {
                if (gender == 'm')
                {
                    dci = BMRMen * 1.2;
                }
                else
                {
                    dci = BMRWomen * 1.2;
                }
            } 
            if (workouts>=1&&workouts<=3)
            {
                if (gender == 'm')
                {
                    dci = BMRMen * 1.375;
                }
                else
                {
                    dci = BMRWomen * 1.375;
                }
            }
            if (workouts >= 4 && workouts <= 6)
            {
                if (gender == 'm')
                {
                    dci = BMRMen * 1.55;
                }
                else
                {
                    dci = BMRWomen * 1.55;
                }
            } if (workouts>=7&&workouts<=9)
            {
                if (gender == 'm')
                {
                    dci = BMRMen * 1.725;
                }
                else
                {
                    dci = BMRWomen * 1.725;
                }
            }
            if (workouts>9)
            {
                if (gender == 'm')
                {
                    dci = BMRMen * 1.9;
                }
                else
                {
                    dci = BMRWomen * 1.9;
                }
            }

            Console.WriteLine(Math.Floor(dci));




        }
    }
}
