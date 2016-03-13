using System;

    class Program
    {
        static void Main()
        {
            Nullable<int> i = null;
            Nullable<double> d = null;

            Console.WriteLine("i = {0}\nd = {1}",i,d);

            i = i + 10;
            d = d + null;

            Console.WriteLine("i = {0}\nd = {1}", i, d);
            Console.WriteLine("i = {0}\nd = {1}", i.GetValueOrDefault(), d.GetValueOrDefault());

           

        }
    }

