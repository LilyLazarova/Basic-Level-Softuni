using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Detective_Boev
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string message = Console.ReadLine();

            int mask = 0;
            
            for (int i = 0; i < secretWord.Length; i++)
            {
                mask+= secretWord[i];
            }
            string maskString = mask.ToString();

            mask = 0;
            while (maskString.Length>1)
            {
                mask = 0;


                for (int i = 0; i < maskString.Length; i++)
                {
                    mask += maskString[i] - '0';
                }

                maskString = mask.ToString();
            }

            StringBuilder decryptedMessage = new StringBuilder();

            int letterAsci = 0;
            char letter;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i]%mask==0)
                {

                    letterAsci = message[i] + mask;
                    letter=(char)letterAsci;
                }
                else
                {
                    letterAsci = message[i] - mask;
                    letter = (char)letterAsci;
                }
                decryptedMessage.Append(letter);
            }

            StringBuilder reversedMessage = new StringBuilder();

            for (int i = decryptedMessage.Length - 1; i >= 0; i--)
            {
                reversedMessage.Append(decryptedMessage[i]);
            }

            string output = reversedMessage.ToString();

            Console.WriteLine(output);
        }
    }
}






//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Problem_2.Detective_Boev
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string keyWord = Console.ReadLine();
//            string message = Console.ReadLine();
//            //Console.WriteLine(message.Length);
//            int sum=0;
//            int mask = 0;
//            int key=0;
//            int digit = 0;
//            int symbolASCII = 0;
//            int temp = 0;
            
//            //calculate Mask

//            for (int i = 0; i < keyWord.Length; i++)
//            {
//                key = keyWord[i];
//                sum += key;
//            }

//            //string maskStr = mask.ToString();
//            //mask = 0;
//            //while (maskStr.Length > 1)
//            //{
//            //    mask = 0;
//            //    for (int i = 0; i < maskStr.Length; i++)
//            //    {
//            //        mask += maskStr[i] - '0';		

//            //    }

//            //    maskStr = mask.ToString();

//            //}
//            while (sum > 9)
//            {
//                mask = 0;
//                while (sum != 0)
//                {
//                    digit = sum % 10;
//                    sum = sum / 10;
//                    mask += digit;
//                }
//                sum = mask;
//            }

//           // Console.WriteLine(mask);

//           //check message to decrypt
//            StringBuilder decryptedMessage = new StringBuilder();

//            for (int j = 0; j < message.Length; j++)
//            {
//                char symbolASCIIChar;
//                symbolASCII = message[j];
//                if (symbolASCII%mask==0)
//                {
                    
//                    symbolASCII=mask + symbolASCII;
//                    symbolASCIIChar = (char)symbolASCII;
                    
                    
//                }
//                else
//                {
//                    symbolASCII = symbolASCII - mask;
//                    symbolASCIIChar = (char)symbolASCII;
//                }
//                decryptedMessage.Append(symbolASCIIChar);

//            }
//            //Console.WriteLine(decryptedMessage);
//            //reverse decrypted Messsage
//            var reversed = decryptedMessage.ToString().Reverse().ToArray();
//            //string output = new string(reversed);
//            string output = string.Join("", reversed);

//            char[] temp1 = decryptedMessage.ToString().ToCharArray();
//            Array.Reverse(temp1);


//            StringBuilder reversedMessage = new StringBuilder();
//            for (int i = decryptedMessage.Length - 1; i >= 0; i--)
//            {
//                reversedMessage.Append(decryptedMessage[i]);
//            }
//            string reversedMessageString = reversedMessage.ToString();

//            Console.WriteLine(reversedMessageString);
            
             
//    }

            


//        }
//    }

