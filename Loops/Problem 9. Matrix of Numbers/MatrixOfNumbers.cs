using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Please, enter a matrix size n = ");
            int matrixSize = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= matrixSize; i++)
            {
               int currentNumber = i;
                for (int j = 1; j <= matrixSize; j++)
                {
                    Console.Write("{0} ",currentNumber);
                    currentNumber += 1;
                } 
                Console.WriteLine();
            }
        }
    }

