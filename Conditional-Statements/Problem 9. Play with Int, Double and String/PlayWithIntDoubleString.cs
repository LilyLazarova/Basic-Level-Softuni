//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. Example:
//program	user		program	user
//Please choose a type:
//1 --> int
//2 --> double
//3 --> string	3		    Please choose a type:
                            //1 --> int
                            //2 --> double
                            //3 --> string	2
//Please enter a string:	hello		Please enter a double:	1.5
//hello*			        2.5	


using System;

    class PlayWithIntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please,choose a type :");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.Write("Please, enter an integer: ");
                    int numberInt = int.Parse(Console.ReadLine());
                    int result = numberInt + 1;
                    Console.WriteLine(result);
                    break;
                case 2: Console.Write("Please, enter a double:");
                    double numberDouble = double.Parse(Console.ReadLine());
                    double  resultD = numberDouble + 1;
                    Console.WriteLine(resultD);
                    break;
                case 3: Console.Write("Please, enter a string:");
                    string inputString = Console.ReadLine();
                    Console.WriteLine(inputString + "*");
                    break;
                default:
                    break;
            }
        }
    }

