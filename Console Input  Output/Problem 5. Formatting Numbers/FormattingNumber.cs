using System;

class FormattingNumber
    {
        static void Main()
        {
            Console.Write(" Enter an integer number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a float number b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a float number c = ");
            double c = double.Parse(Console.ReadLine());
           

            if (a >= 0 && a <= 500)
            {
                var binary = Convert.ToString(a,2);
                
                Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|{3,-40}|", 'a', 'b', 'c',"result" );    
                Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|{3,-10:X}|{4,10}|{5,10:F2}|{6,-10:F3}|",a,b,c,a,binary, b, c);
                
               

            }
            else
            {
                Console.WriteLine("The number 'a ' should be in the interval [0,500]");
            }
        }
    }

