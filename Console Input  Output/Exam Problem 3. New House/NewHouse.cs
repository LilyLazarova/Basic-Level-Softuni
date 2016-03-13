using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintRoof(n);
        PrintFloor(n);
    }

    public static void PrintFloor(int n)
    {
        for (int i = 0; i < n; i++)
        {
            string wall = "|";
            string insidePart = new string('*', n-2);
            Console.WriteLine("{0}{1}{0}",wall,insidePart);
        }
    }

    public static void PrintRoof(int n)
    {
        char asterix = '*';
        char dash = '-';
        int middlePosition = (n + 1) / 2;

        for (int i = 0; i < middlePosition; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j < (middlePosition - i) || j > (middlePosition + i))
                {
                    Console.Write(dash);
                }
                else
                {
                    Console.Write(asterix);
                }
            }
            Console.WriteLine();
        }
    }
}



//===========================================================================
// Original

//using System;

//class NewHouse
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        for (int i = 1; i <= n; i += 2)
//        {
//            int dashesCount = (n - i) / 2;
//            string dashes = new string('-', dashesCount);
//            string asterisks = new string('*', i);
//            Console.Write(dashes);
//            Console.Write(asterisks);
//            Console.Write(dashes);
//            Console.WriteLine();
//        }
//        for (int i = 1; i <= n; i++)
//        {
//            Console.WriteLine("{0}{1}{0}", "|", new string('*', n - 2));
//        }
//    }
//}