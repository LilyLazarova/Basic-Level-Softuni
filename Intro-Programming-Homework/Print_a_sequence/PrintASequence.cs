using System;

class PrintASequence
    {
        static void Main()
        {
            int evenNumber = 2;
            int oddNumber = -3;
            

            for (int n = 0; n < 100; n++)
                if (n == 0 || n%2 == 0)
                {
                    
                    System.Console.Write(evenNumber + ",");
                    evenNumber = evenNumber + 2;
                    
                }
                else
                {
                    System.Console.Write(oddNumber + ",");
                    oddNumber += -2;
                }
        } 
    }

