using System;

    class Age
    {
        static void Main()
        {
            
            Console.WriteLine("Enter your birth date(mm/dd/yyyy):");
            string input = Console.ReadLine();
            DateTime bday = new DateTime();
            DateTime today = DateTime.Now.Date;

            if (DateTime.TryParse(input,out bday))
            { 
                if (bday > today)
                {
                    Console.WriteLine("You should wait till you born :)");
                }

                else
                {
                    TimeSpan years = today.Subtract(bday);
                    Console.WriteLine("You are " + Math.Truncate(years.Days / 365.25) + "years old");
                    Console.WriteLine("After 10 years you will be:" + Math.Truncate(years.Days / 365.25 + 10));
                }
            } 
 
            else
	        {
                Console.WriteLine("Please, enter the date in the correct format");
	        }   
                
            }
            
            
        }
    

