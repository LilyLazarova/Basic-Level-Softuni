using System;

class NumsDividableByGivenNum
{
    static void Main()
    {
        Console.WriteLine("Enter 2 positive integer numbers for start and end of the interval:");
        Console.Write("n1 = ");
        
        int startOfInterval;
        bool isStartInteger = int.TryParse(Console.ReadLine(), out startOfInterval);
        Console.Write("n2 = ");
       
        int endOfInterval;
        bool isEndInteger = int.TryParse(Console.ReadLine(),out endOfInterval);
        int result = 0;

        if (isStartInteger && isEndInteger && startOfInterval >0 && endOfInterval > 0)
        {
            for (int i = startOfInterval; i <= endOfInterval; i++)
            {
                if ((i%5) == 0)
                {
                    result++;
                    Console.WriteLine(i);
                }
               
            }
            Console.WriteLine("result = {0}", result);
            
        }
        else
        {
            Console.WriteLine("Enter possitive integer numbers!");
        }

    }
}
