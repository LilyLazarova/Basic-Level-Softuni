using System;

class CheckBit
    {
        static void Main()
        {
            Console.Write("Enter positive integer number:");
            int number = 0;
            bool isNumberInteger = int.TryParse(Console.ReadLine(), out number);
            Console.Write("Enter bit position you would like to check:");
            int bitPosition = 0;
            bool isBitPositionInt = int.TryParse(Console.ReadLine(), out bitPosition);

            int bit;

            if (isNumberInteger && isBitPositionInt && number >= 0 && bitPosition >= 0)
            {
                int newNumber = number >> bitPosition;
                bit = newNumber & 1;
                
                if (bit == 1)
                {
                    Console.WriteLine("Is bit @ position p 1? : true" );
                }
                else
                {
                    Console.WriteLine("Is bit @ position p 1? : false");
                }
                
            }
            else
            {
                Console.WriteLine("Please, enter positive integer number!");
            }
        }
    }

