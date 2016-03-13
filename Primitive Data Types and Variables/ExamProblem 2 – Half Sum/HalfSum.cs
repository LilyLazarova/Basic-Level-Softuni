using System;

    class HalfSum
    {
        static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int numbersInBothSequences = 2 * countOfNumbers;
            int numberFromConsole;
            int sum1 =0, sum2=0;


            for (int i = 0; i < countOfNumbers; i++)
            {
                numberFromConsole = int.Parse(Console.ReadLine());
                sum1 += numberFromConsole;
                
            }

           
            for (int j = countOfNumbers; j < numbersInBothSequences; j++)
            {
                numberFromConsole = int.Parse(Console.ReadLine());
                sum2 += numberFromConsole;
                
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum=" + sum1);
            }
            else
            {
                Console.WriteLine("No, diff=" + Math.Abs(sum1 - sum2));
            }
            
        }
    }

