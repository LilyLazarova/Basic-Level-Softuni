using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter the number of numbers n = ");
        int n;
        double sum = 0;
        bool isnInteger = int.TryParse(Console.ReadLine(), out n);

        if (isnInteger)
        {
            for (int i = 0; i < n; i++)
            {
                
                double num;
                bool isNumDouble= double.TryParse(Console.ReadLine(),out num);

                if (isNumDouble)
                {
                    sum += num;
                }
                else
                {
                    Console.WriteLine("Please, enter a real number");
                    break;
                }
                
            }
            Console.WriteLine("Sum = {0}",sum);
        }
        else
        {
            Console.WriteLine("Please, enter an integer number!");
        }
    }
}
