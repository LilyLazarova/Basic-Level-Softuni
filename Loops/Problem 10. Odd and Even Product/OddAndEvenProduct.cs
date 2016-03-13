using System;

class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("Enter a sequence of  integer numbers separated by space :");
            string[] inputNumbers = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(inputNumbers,int.Parse);
            int productOdd = 1;
            int productEven = 1;

            for (int i = 0; i <numbers.Length ; i++)
            {
                if (i%2==1)
                {
                    productEven *= numbers[i];
                }
                else
                {
                    productOdd *= numbers[i];
                }
            } 
            if (productOdd==productEven)
            {
                Console.WriteLine("yes \nproduct = {0}",productEven);
            }
            else
            {
                Console.WriteLine("no \n odd_product = {0}\n even_product = {1}",productOdd,productEven);
            }
        }
    }

