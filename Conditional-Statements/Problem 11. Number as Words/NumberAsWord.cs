//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
//numbers	number as words
//0	Zero
//9	Nine
//10	Ten
//12	Twelve
//19	Nineteen
//25	Twenty five
//98	Ninety eight
//273	Two hundred and seventy three
//400	Four hundred
//501	Five hundred and one
//617	Six hundred and seventeen
//711	Seven hundred and eleven
//999	Nine hundred and ninety nine

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class NumberAsWord
{
    static void Main()
    {
        Dictionary<int, string> NumbersToWords = new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" }
        };

        string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        Console.Write("Please, enter a digit in [0,999] you want to convert to word : ");
        string number = Console.ReadLine();
        int numberParsed = int.Parse(number);
        int numberOfOnes = numberParsed % 10;
        int numberOfHundreds = numberParsed / 100;
        int numberOfTens;

        //1-digit number
        if (numberParsed >= 0 && numberParsed <= 9)
        {
            number = ones[numberParsed];
            string capitalizedNumber = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(number); //capitalize first letter of every word in string --> for the next cases when number contain more word another method should be used.
            Console.WriteLine(capitalizedNumber);
        }
        //2-digits number between 10 and 19
        if (numberParsed >= 10 && numberParsed <= 19)
        {
            number = teens[numberParsed - 10];
            string capitalizedNumber = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(number);
            Console.WriteLine(capitalizedNumber);
        }
        //2-digits number from 20 to 99
        if (numberParsed >= 20 && numberParsed <= 99 && numberOfOnes == 0)
        {
            numberOfTens = numberParsed / 10;
            number = tens[numberOfTens - 1];
            string capitalizedNumber = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(number);
            Console.WriteLine(capitalizedNumber);
        }
        else if (numberParsed >= 20 && numberParsed <= 99)
        {
            numberOfOnes = numberParsed % 10;
            numberOfTens = numberParsed / 10;
            number = tens[numberOfTens - 1] + " " + ones[numberOfOnes];
            string capitalizedNumber = number.First().ToString().ToUpper() + String.Join("", number.Skip(1)).ToLower();
            Console.WriteLine(capitalizedNumber);
        }
        // 3-digit numbers between 100 and 999
        if (numberParsed >= 100 && numberParsed <= 999)
        {
            numberOfOnes = numberParsed % 10;
            numberOfHundreds = numberParsed / 100;
            numberOfTens = (numberParsed % 100) / 10;

            if (numberOfOnes == 0 && numberOfTens == 0)
            {
                numberOfHundreds = numberParsed / 100;
                number = ones[numberOfHundreds];
                string capitalizedNumber = number.First().ToString().ToUpper() + String.Join("", number.Skip(1)).ToLower();
                Console.WriteLine(capitalizedNumber + " " + "hundred");
            }
            else if (numberOfOnes == 0)
            {
                number = ones[numberOfHundreds] + " hundred " + " and " + tens[numberOfTens - 1];
                string capitalizedNumber = number.First().ToString().ToUpper() + String.Join("", number.Skip(1)).ToLower();
                Console.WriteLine(capitalizedNumber);
            }
            else if (numberOfTens == 1)
            {
                number = ones[numberOfHundreds] + " hundred " + " and " + teens[numberOfOnes];
                string capitalizedNumber = number.First().ToString().ToUpper() + String.Join("", number.Skip(1)).ToLower();
                Console.WriteLine(capitalizedNumber);
            }
            else
            {
                number = ones[numberOfHundreds] + " hundred " + " and " + tens[numberOfTens - 1] + " " + ones[numberOfOnes];
                string capitalizedNumber = number.First().ToString().ToUpper() + String.Join("", number.Skip(1)).ToLower();

                Console.WriteLine(NumbersToWords[numberOfOnes]);
                Console.WriteLine(capitalizedNumber);
            }
        }
    }
}

