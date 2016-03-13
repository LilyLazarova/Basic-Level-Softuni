using System;

    class DecToHex
    {
        static void Main()
        {
            Console.WriteLine("Please, enter decimal number to convert to hexadecimal n = ");
            string input = Console.ReadLine();
            long number = long.Parse(input);
            long reminder = 0;
            char symbol='\u0000';
            string result = string.Empty;

            while (number > 0)
            {
                reminder = number % 16;
                number = number / 16;
                if (reminder > 9 && reminder <= 15)
                {
                    switch (reminder)
                    {
                        case 10: symbol = 'A'; result = symbol + result; break;
                        case 11: symbol = 'B'; result = symbol + result; break;
                        case 12: symbol = 'C'; result = symbol + result; break;
                        case 13: symbol = 'D'; result = symbol + result; break;
                        case 14: symbol = 'E'; result = symbol + result; break;
                        case 15: symbol = 'F'; result = symbol + result; break;
                        default:
                            break;
                    } continue;
                }
                result = reminder.ToString() + result;
            } Console.WriteLine(result);
        }
    }

