using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the size of the matrix (1<n<20) n = ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int maxNumber = n * n;

            int currentNumber = 1;
            int x =0;
            int y =0;

            Console.Clear();

            for (int i = 1; i <= maxNumber; i++)
            {
                Console.SetCursorPosition(x, y);

                if (i>0 && i<=n)
                {
                    Console.SetCursorPosition(i, y);
                } 
                if (i>n && i<=2*n-1)
                {
                    Console.SetCursorPosition(x, y);
                    
                }
            }

           
            
            }
        }
    

