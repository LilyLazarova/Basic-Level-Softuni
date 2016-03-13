using System;

    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 real numbers:");
            double number1, number2, number3, number4, number5,sum;
            number1 = double.Parse(Console.ReadLine());
            number2 = double.Parse(Console.ReadLine());
            number3 = double.Parse(Console.ReadLine());
            number4 = double.Parse(Console.ReadLine());
            number5 = double.Parse(Console.ReadLine());
            sum = number1 + number2 + number3 + number4 + number5;

            Console.WriteLine("{0} {1} {2} {3} {4}  sum = {5}",number1,number2,number3,number4,number5,sum);

        }
    }

