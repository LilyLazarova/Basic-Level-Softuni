using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Enter positive integer number:");
            int number = 0;
            bool isNumberInteger = int.TryParse(Console.ReadLine(), out number);
            Console.Write("Enter bit position you would like to extract:");
            int bitPosition = 0;
            bool isBitPositionInt = int.TryParse(Console.ReadLine(), out bitPosition);

            int bit;

            if (isNumberInteger && isBitPositionInt && number >= 0 && bitPosition >= 0)
            {
                int newNumber = number >> bitPosition;
                bit = newNumber & 1;
                Console.WriteLine("Bit @ position p :{0}",bit);
            }
            else
            {
                Console.WriteLine("Please, enter positive integer number!");
            }
        }
    }

