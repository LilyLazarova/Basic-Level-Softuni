using System;

class HextoDec
    {
        static void Main()
        {
            Console.Write("Please, enter a hexadecimal number n = ");
            string input = Console.ReadLine();
            int digit = 0;
            double digitOnPower = 0;
            long sum = 0L;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                digit = input[i] - '0';

                if (digit>=0&&digit<=9)
                {
                    digitOnPower = digit*(Math.Pow(16, input.Length - i - 1));
                    sum += (long)digitOnPower;
                }
                else if (digit >=17 && digit<=22 )
                {
                    switch (digit)
                    {
                        case 17: digit -= 7; digitOnPower = digit * (Math.Pow(16, input.Length - i - 1)); 
                            sum += (long)digitOnPower;break;
                        case 18: digit -= 7; digitOnPower = digit * (Math.Pow(16, input.Length - i - 1));
                            sum += (long)digitOnPower; break;
                        case 19: digit -= 7; digitOnPower = digit * (Math.Pow(16, input.Length - i - 1));
                            sum += (long)digitOnPower; break;
                        case 20: digit -= 7; digitOnPower = digit * (Math.Pow(16, input.Length - i - 1));
                            sum += (long)digitOnPower; break;
                        case 21: digit -= 7; digitOnPower = digit * (Math.Pow(16, input.Length - i - 1));
                            sum += (long)digitOnPower; break;
                        case 22: digit -= 7; digitOnPower = digit * (Math.Pow(16, input.Length - i - 1));
                            sum += (long)digitOnPower; break;
                        default:
                            break;
                    }
                }
            } Console.WriteLine("Decimal number = {0}", sum);
        }
    }

//=========================================================================================================================

////Better solution below

//using System;

//class HexadecimalToDecimal
//{
//    static void Main()
//    {
//        // declarations
//        long number = 0;
//        long power = 1;

//        // input
//        Console.Write("Please enter a hexadecimal integer number: ");
//        string hex = Console.ReadLine();

//        // retrieving the string array of symbols
//        for (int i = hex.Length - 1; i >= 0; i--)
//        {
//            int symbol;

//            // converting string symbols to long values
//            switch (hex[i])
//            {
//                case 'A': symbol = 10;
//                    break;
//                case 'B': symbol = 11;
//                    break;
//                case 'C': symbol = 12;
//                    break;
//                case 'D': symbol = 13;
//                    break;
//                case 'E': symbol = 14;
//                    break;
//                case 'F': symbol = 15;
//                    break;
//                default: symbol = hex[i] - '0';
//                    break;
//            }

//        // digit * i-th power of 16
//            number += symbol * power;
//            power *= 16;
//        }

//        Console.WriteLine("\nThe string you entered is the binary representation of {0}\n", number);
//    }
//}