using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Difference_between_Dates
{
    class DiffBetweenDates
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter first date in format dd.MM.yyyy : ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy",System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Please, enter second date in format dd.MM.yyyy : ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan period = secondDate - firstDate;
            int days = period.Days;
            Console.WriteLine(days);
        }
    }
}
