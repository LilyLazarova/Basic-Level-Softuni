//HAVE to be FIXED


using System;
using System.Collections.Generic;

    class RandomizeTheNumbers
    {
        static void Main()
        {
            Console.Write("Enter integer number n = ");
            int number = int.Parse(Console.ReadLine());
            int randomNumber, temp;
            int[] numbers = new int[number];
            int[] mixedArray= new int[number];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            for (int i = 0; i < mixedArray.Length; i++)
            {
                randomNumber = random.Next(mixedArray.Length);

                temp = mixedArray[i];
                mixedArray[i] = mixedArray[randomNumber];
                mixedArray[randomNumber] = temp;
            }
            foreach (int num in mixedArray) 
            {
                Console.WriteLine("{0} ",num);
            }
            //Console.Write("Enter integer number n = ");
            //int number = int.Parse(Console.ReadLine());
            //Random random = new Random();
            //int[] numbers = new int[number];
            //bool isNumberPrinted = false;
            //int k = 0;
            //bool z=false;

            //do
            //{
            //    int randomNumber = random.Next(1, number + 1);
                

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i]==randomNumber)
            //        {
            //            isNumberPrinted = true;
                        
            //           // Console.Write("{0} ",randomNumber);
            //        } if (isNumberPrinted==false)
            //        {
            //            numbers[k] = randomNumber;
            //            Console.WriteLine(randomNumber);
            //            k++;
            //        } if (k==number)
            //        {
            //            z=true;
            //        }
            //        //if (isNumberPrinted==false)
            //        //{
                        
            //        //}
            //    }

            //} while (z==true);

    //        do
    //        {
    //           int randomNumber = random.Next(1,number+1); 
    //             bool check =false;
           
    //        for (int i = 0; i < number; i++)
    //        {
    //            if (numbers[i]==randomNumber)
    //{
    //     check=true;
    //}
    //            if (numbers[i]==0 && check==false)
    //            {
    //                numbers[i]=randomNumber;
    //                //Console.Write("{0} ", randomNumber);
    //                if (i==number-1)
    //{
    //     check2= false;
    //}
    //                break;
    //            }
    //        }
    //        } while (check2==false);

    //        for (int i = 0; i < numbers.Length; i++)
    //        {
                
    //            Console.WriteLine(numbers[i]);
    //        }
            
        }
    }

