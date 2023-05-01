using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegelurExpression
{
    public class RegPatterns
    {
        static string NamePattern = @"^[A-Z]{1}[a-z]{3,}(\s|_)[A-Z]{1}[a-z]{3,}$";
        static string EmailPattern = @"^[a-z0-9.]{3,20}@[a-z]{3,10}.(com|co|in)$";
        static string PhonePattern = @"^[(]{1}\+[0-9]{2,3}[)]{1}(\s|-)[0-9]{4}(-|\s)[0-9]{3}(-|\s)[0-9]{3}$";

        public  void Name()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter Name:");
                string name=Convert.ToString(Console.ReadLine());
                var flags = Regex.IsMatch(name, NamePattern);

                if (flags)
                {
                    Console.WriteLine("Name Valid");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Name is Invalid");
                   
                }
            }

        }
        public void Email()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter Email:");
                string email = Convert.ToString(Console.ReadLine());
                var flags = Regex.IsMatch(email,EmailPattern);

                if (flags)
                {
                    Console.WriteLine("Email is Valid");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Email is Invalid");

                }
            }

        }
        public void Phone()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter Phone Number:");
                string number = Convert.ToString(Console.ReadLine());
                var flags = Regex.IsMatch(number, PhonePattern);

                if (flags)
                {
                    Console.WriteLine("Phone number is Valid");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Phone number is Invalid");

                }
            }

        }
    }
}
