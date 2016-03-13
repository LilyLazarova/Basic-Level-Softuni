//Still doesn't work correctly

using System;


class Sunglasses
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        
            PrintFirstPart(n);
            Console.SetCursorPosition((2 * n) + 1,n );
               
            PrintMiddlePart(n);
        
    }

    private static void PrintFirstPart(int n)
    {
        string s1 = "*";
        string s2 = new string('/', (2 * n - 2));
        string s3 = s1 + s2 + s1;
        string s4 = new string('*', 2 * n);
       

        for (int i = 0; i <= n; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(s4);
            }
            if (i > 1 && i < n)
            {
                Console.WriteLine(s3);
            }

            if (i == n)
            {
                Console.WriteLine(s4);
            }
           


        }
    }

    private static void PrintMiddlePart(int n)
    {

        string s5 = new string ('|',n);
        string s6 = new string(' ', n);
        

       

        for (int i = 0; i <= n; i++)
        {
            if (i == (n+1)/2)
            {
                Console.WriteLine(s5) ;
            }
            if (i >= 1 && i < (n + 1) / 2)
            {
                Console.WriteLine(s6);
            }
            if (i > (n + 1) / 2 && i <= n )
            {
                Console.WriteLine(s6);
            }
            
        }
        
    }
    private static void MoveCoursorPosition(int n)
    {
        
        int k = 2 * n;
        Console.SetCursorPosition(k, 1);
    }

}
