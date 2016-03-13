using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_17.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int htWeekends = int.Parse(Console.ReadLine());
            int normalWeekends = 48 - htWeekends;
            double numberOfHolidayPlay = (numberOfHolidays * 2) / 3;
            double normalWeekendsPlay = (normalWeekends *3) / 4;
            double timesPlay = htWeekends + numberOfHolidayPlay + normalWeekendsPlay;

            if (year == "leap")
            {
                timesPlay = (int) (((15 * timesPlay)/100) + timesPlay);
                Console.WriteLine(timesPlay);
            }
            else
            {
                Console.WriteLine((int)timesPlay);
            }

        }
    }
}
