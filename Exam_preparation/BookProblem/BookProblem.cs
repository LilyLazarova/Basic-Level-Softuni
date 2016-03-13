using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProblem
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            int pageCount = int.Parse(Console.ReadLine());
            int campDays = int.Parse(Console.ReadLine());
            int numberPagesReadNormalDay = int.Parse(Console.ReadLine());

            if(campDays==30 || numberPagesReadNormalDay==0)
            {
                Console.WriteLine("never");
                return;

            } 
            int pageReadperMonths = (30-campDays)*numberPagesReadNormalDay;
            double monthsNeeded = Math.Ceiling((pageCount /(double) pageReadperMonths));
            double yearsNeeded = monthsNeeded / 12;
            monthsNeeded = monthsNeeded%12;

            //double monthsNeeded = Math.Round(pageCount % yearsNeeded);


              //string output=string.Format("{0} years {1} months",yearsNeeded,(int)monthsNeeded);
              Console.WriteLine("{0} years {1} months", (int)yearsNeeded, (int)monthsNeeded);
	        }

            
        }
    }

