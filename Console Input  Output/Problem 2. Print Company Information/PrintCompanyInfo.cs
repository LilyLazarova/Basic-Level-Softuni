using System;

class PrintCompanyInfo
    {
        static void Main()
        {
            string companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerPhone;
            byte managerAge;
            Console.Write("Company name:");
            companyName = Console.ReadLine();
            Console.Write("Company address:");
            companyAddress = Console.ReadLine();
            Console.Write("Phone number:");
            phoneNumber = Console.ReadLine();
            Console.Write("Fax number:");
            faxNumber = Console.ReadLine();
            Console.Write("Web site:");
            webSite = Console.ReadLine();
            Console.Write("Manager's first name:");
            managerFirstName = Console.ReadLine();
            Console.Write("Manager's last name:");
            managerLastName = Console.ReadLine();
            Console.Write("Manager's age:");
            bool isParseAgeOk = byte.TryParse(Console.ReadLine(), out managerAge);
            Console.Write("Manager's phone:");
            managerPhone = Console.ReadLine();

            if (isParseAgeOk)
            {
                Console.WriteLine("Company name:{0}\nCompany address:{1}\nPhone number:{2}\nFax number:{3}\nWeb site:{4}\nManager's first name:{5}\nManager's last name:{6}\nManager's age:{7}\nManager's phone:{8}", 
                    companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName,managerAge, managerPhone); 
            }

            else
            {
                Console.WriteLine("Please, enter a valid age!");
                Console.WriteLine();
                Console.WriteLine("Company name:{0}\nCompany address:{1}\nPhone number:{2}\nFax number:{3}\nWeb site:{4}\nManager's first name:{5}\nManager's last name:{6}\nManager's phone:{7}",
                    companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerPhone);
            }
        }
    }

