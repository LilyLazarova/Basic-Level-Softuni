using System;

    class ExtractBit3
    {
        static void Main()
        {
            Console.Write("Enter positive integer number:");
            int number = 0;
            bool isNumberInteger = int.TryParse(Console.ReadLine(), out number);
            int bitPosition = 3;
            int bit;

            if (isNumberInteger && number >= 0)
            {
                int newNumber = number >> bitPosition;
                bit = newNumber & 1;
                Console.WriteLine(bit);
            }
            else
            {
                Console.WriteLine("Please, enter positive integer number!");
            }
        }
    }

