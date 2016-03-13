using System;

    class DevideBy7and5
    {
        static void Main()
        {
            Console.Write("Enter an integer:");
            string input = Console.ReadLine();
            int number = 0;
            bool isNumberInteger = int.TryParse(input, out number);
            bool devideBy5 = (number % 5 == 0);
            bool devideBy7 = (number % 7 == 0);
            bool devideBy5And7 = devideBy5 && devideBy7;

            if (isNumberInteger)
            {
                if ( devideBy5And7)
                {
                    Console.WriteLine("Divided by 7 and 5? : {0}",devideBy5And7);
                }
                else
                {
                    Console.WriteLine("Divided by 7 and 5?:{0}",devideBy5And7);
                }
            }
            else
            {
                Console.WriteLine("Please, enter an integer number!");
            }
            

        }
    }
