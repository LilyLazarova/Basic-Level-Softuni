using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Four_Factors
{
    class FourFactors
    {
        static void Main(string[] args)
        {
            double FG = double.Parse(Console.ReadLine());
            double FGA = double.Parse(Console.ReadLine()); ;
            double threeP = double.Parse(Console.ReadLine()); ;
            double TOV = double.Parse(Console.ReadLine()); ;
            double ORB = double.Parse(Console.ReadLine()); ;
            double oppDRB = double.Parse(Console.ReadLine()); ;
            double FT = double.Parse(Console.ReadLine()); ;
            double FTA = double.Parse(Console.ReadLine()); ;

            double EFGPercentage = (FG + (0.5 * threeP))/FGA;
            double TOVPercentage = TOV / (FGA + 0.44 * FTA + TOV);
            double ORBPercentage = ORB / (ORB + oppDRB);
            double FTPercentage = FT / FGA;

            Console.WriteLine("eFG% {0:f3}", EFGPercentage);
            Console.WriteLine("TOV% {0:f3}",TOVPercentage);
            Console.WriteLine("ORB% {0:f3}",ORBPercentage);
            Console.WriteLine("FT% {0:f3}",FTPercentage);


        }
    }
}
