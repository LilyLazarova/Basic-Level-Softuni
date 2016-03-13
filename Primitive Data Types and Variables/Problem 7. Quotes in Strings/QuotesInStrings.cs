using System;

    class QuotesInStrings
    {
        static void Main()
        {
            string s1 = "The \"use\" of quotations causes difficulties.";
            string s2 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("{0}\n{1}",s1,s2);
          
        }
    }

