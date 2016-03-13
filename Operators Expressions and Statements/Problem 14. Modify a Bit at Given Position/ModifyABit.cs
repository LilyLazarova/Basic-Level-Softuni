using System;

    class ModifyABit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter positive integer number:");
            int number = 0;
            bool isNumberInteger = int.TryParse(Console.ReadLine(), out number);
            Console.Write("Enter bit position you would like to change:");
            int bitPosition = 0;
            bool isBitPositionInt = int.TryParse(Console.ReadLine(), out bitPosition);
            Console.Write("Enter 1 or 0 for the bit you want to change:");
            int bitType;
            bool isBitTypeOK = int.TryParse(Console.ReadLine(), out bitType);

            if (isNumberInteger && isBitPositionInt && isBitTypeOK && number >= 0 && bitPosition >= 0 && (bitType == 0 || bitType == 1))
            {
                if (bitType == 1)                       //change the bit to 1
                {
                    int mask = 1<<bitPosition;
                    int changedNumber = number | mask;
                    Console.WriteLine("The new number is: {0}",changedNumber);
                }
                else                                    //change the bit to 0
                {
                    int mask = ~(1 << bitPosition);
                    int changedNumber = number & mask;
                    Console.WriteLine("The new number is: {0}", changedNumber);
                }
            }
            else
            {
                Console.WriteLine("Please, enter positive integer number or valid bit value (1 or 0)!");
            }
        }
    }

