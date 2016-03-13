

using System;

    class BankAccountData
    {
        static void Main()
        {

            string firstName;
            string middleName;
            string lastName;
            decimal balance;
            string bankName;
            string IBAN;
            long  creditCardNumber1;
            long creditCardNumber2;
            long creditCardNumber3;

            firstName = "Liliya";
            middleName = "Nikolaeva";
            lastName = "Lazarova";
            balance = 23456.24m;
            bankName = "First Investment Bank";
            IBAN = "23BG123456789123";
            creditCardNumber1 = 9876543211234;
            creditCardNumber2 = 9876543211345;
            creditCardNumber3 = 9876543211456;

            Console.WriteLine("Name: {0} {1} {2} \nBalance: {3}\nBankName: {4}\nIBAN: {5}\nCredit Card Number1: {6}\nCredit Card Number2: {7}\nCredit Card Number3: {8}", firstName, middleName, lastName, balance, bankName, IBAN, creditCardNumber1, creditCardNumber2, creditCardNumber3);



        }
    }

