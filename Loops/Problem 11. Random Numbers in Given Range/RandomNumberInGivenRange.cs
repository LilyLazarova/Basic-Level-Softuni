using System;

    class RandomNumberInGivenRange
    {
        static void Main()
        {
            Console.Write("Enter integer number (count of the numbers in interval [min,max]) n = ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the minimum value of the interval min = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum value of the interval max = ");
            int max = int.Parse(Console.ReadLine());
            Random random = new Random();
            
            for (int i = 0; i < number; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                Console.Write("{0} ",randomNumber);
            }
         }
    }

