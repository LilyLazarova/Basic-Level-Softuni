//why tryparse is successfull when you enter the double number using ',' instead of '.'?

using System;

class SumOf3Numbers
    {
        static void Main()
        {
            double number1, number2, number3;
            Console.Write("a = ");
            string input1 = Console.ReadLine();
            bool parseOk1 = double.TryParse(input1, out number1);

            Console.Write("b = ");
            string input2 = Console.ReadLine();
            bool parseOk2 = double.TryParse(input2, out number2);

            Console.Write("c = ");
            string input3 = Console.ReadLine();
            bool parseOk3 = double.TryParse(input3, out number3);

            double sum = number1 + number2 + number3;

            if (parseOk1 && parseOk2 && parseOk3)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Please, enter real numbers!");
            }
            

            
        }
    }

