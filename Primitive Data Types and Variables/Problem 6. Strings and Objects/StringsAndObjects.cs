using System;


class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string s1 = "Hello ";
            string s2 = "World";
            object concatenation = s1 + s2;

            string s3 = (string)concatenation;

            Console.WriteLine(s3);
        }
    }

