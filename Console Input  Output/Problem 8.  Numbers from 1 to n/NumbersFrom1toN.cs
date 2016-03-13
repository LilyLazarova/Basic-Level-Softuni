using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("Please, enter an integer number, that is the end of interval n = ");
        int n;
        bool isNInteger = int.TryParse(Console.ReadLine(), out n);

        if (isNInteger)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("The number you entered is not an integer number");
        }
    }
}
