using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
           Console.Write("Enter the weight of a man on the Earth:");
           string input = Console.ReadLine();
           double weightEarth;
           bool isWeightOK = double.TryParse(input,out weightEarth );
           double weightMoon = (17 * weightEarth) / 100;

           if (isWeightOK && weightEarth >0)
           {
               Console.WriteLine(weightMoon);
           }
           else
           {
               Console.WriteLine("Please, enter positive number!");
           }
        }
    }

