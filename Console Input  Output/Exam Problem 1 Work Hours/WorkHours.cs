using System;

    class WorkHours
    {
        static void Main()
        {
            
            int reqWorkingHours=int.Parse(Console.ReadLine());
            int daysAvailable=int.Parse(Console.ReadLine());
            double productivity= double.Parse(Console.ReadLine());

            double workingHours = (daysAvailable *12) - (daysAvailable *12 )* 0.1;
            double workingHoursEfficient = (productivity * workingHours) / 100;
            double diff = Math.Floor(workingHoursEfficient - reqWorkingHours) ;

            if (diff<0)
	            {
		             Console.WriteLine("No");
                     Console.WriteLine(diff);
                }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine(diff);
            }

            
        }
    }

