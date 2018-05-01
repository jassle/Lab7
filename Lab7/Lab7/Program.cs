using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Input
            string Name = NameVer("Please enter your first name starting with a capital letter:");
            Console.WriteLine(Name);
            string Email = EmailVer("Please enter your email address:");
            Console.WriteLine(Email);
            string Phone = PhoneNumVer("Please enter your phone number XXX-XXX-XXXX:");
            Console.WriteLine(Phone);
            string Birthday = BirthVer("Please enter your date of birth XX/XX/XXXX:");
            Console.WriteLine(Birthday);
            

           
        }
        static string NameVer(string prompt)
        {
            Console.WriteLine(prompt);
            string firName = Console.ReadLine();

            while (!Regex.IsMatch(firName, @"^[A-Z][a-z]{0,29}$"))
            {
                Console.WriteLine("invalid first name format");
                Console.WriteLine(prompt);
                firName = Console.ReadLine();
            }

            return firName;
        }

        //static string NameVer(string firName)
        //{ 
        //while (!Regex.IsMatch(firName, @"^[A-Z][a-z]{0,29}$"))
        //    {
        //        Console.WriteLine("Please enter your first name starting with a capital letter:");
        //        firName = Console.ReadLine();
        //    }
   
        //    return firName;
        //}
        static string EmailVer(string prompt)
        {
            
            Console.WriteLine(prompt);
            string email = Console.ReadLine();

            while (!Regex.IsMatch(email, @"^[A-Za-z0-9]{5,30}@[A-Za-z0-9]{3,10}.[A-Za-z0-9]{2,3}$"))
            {
                Console.WriteLine("invalid email format");
                Console.WriteLine(prompt);
                email = Console.ReadLine();
            }
            return email;
        }
        static string PhoneNumVer(string prompt)
        {
            Console.WriteLine(prompt);
            string phone = Console.ReadLine();

            while (!Regex.IsMatch(phone, @"\d{3}-\d{3}-\d{4}"))
            {
                Console.WriteLine("invalid phone number format");
                Console.WriteLine(prompt);
                phone = Console.ReadLine();
            }
            return phone;
        }
        static string BirthVer(string prompt)
        {
            Console.WriteLine(prompt);
            string bday = Console.ReadLine();

            while (!Regex.IsMatch(bday, @"^\d{2,2}/\d{2,2}/\d{4,4}$"))
            {
                Console.WriteLine("invalid date format");
                Console.WriteLine(prompt);
                bday = Console.ReadLine();
            }

            return bday;
        }

    }
}