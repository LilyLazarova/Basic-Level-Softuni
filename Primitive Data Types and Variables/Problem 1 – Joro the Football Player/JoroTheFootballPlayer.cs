using System;

    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            
            char leapYear = Convert.ToChar(Console.ReadLine());
            // Console.WriteLine("Enter the holidays in the year:");

            double holidays = double.Parse(Console.ReadLine());
            //Console.WriteLine(p);

            //Console.WriteLine("Enter the number of weekends in Joro's home town:");

            double homeTownDays = double.Parse(Console.ReadLine());

            //Console.WriteLine("Please, enter \"t\" for leap year or \"f\" for not leap year: ");


            double homeTownPlays = homeTownDays;
            double normalWeekendsPlays = ((52 - homeTownDays) * 2) / 3;
            double holidayPlays = (holidays / 2);


            double daysJoroPlay = holidayPlays + homeTownPlays + normalWeekendsPlays;

            if (leapYear.Equals('t'))
            {
                Console.WriteLine((int)(daysJoroPlay + 3));
                //Console.WriteLine(Math.Round(daysJoroPlay + 3));
            }

            else
            {
                Console.WriteLine((int)daysJoroPlay);
                //Console.WriteLine(Math.Round(daysJoroPlay));
            }
        }
    }
