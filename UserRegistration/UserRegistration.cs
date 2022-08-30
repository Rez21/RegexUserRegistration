using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class UserValidation
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z]{1}[a-zA-Z]{2,}$");
        public Regex LastNameRegex = new Regex(@"^[A-Z]{1}[a-zA-Z]{2,}$");
        public Regex UserEmail = new Regex(@"^[A-Z a-z 0-9]+([.-_+][A-Z a-z 0-9]+)*@[A-Z a-z 0-9]+.[A-Z a-z]{2,4}([.][A-Z a-z]{2,})?$");
        public Regex MobileNumber = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        //public Regex UserPassword = new Regex(@"^[a-zA-z]{8,}$");
        public Regex UserPassword = new Regex(@"^(=?.*[A-Z]).{8,}$");
        public void ValidateFirstName(string FirstName)
        {
            Console.WriteLine("\nFirst name: " + FirstName);
            if (FirstNameRegex.IsMatch(FirstName))
                Console.WriteLine("Valid First Name");
            else
                Console.WriteLine("Invalid First Name");
        }
        public void ValidateLastName(string LastName)
        {
            Console.WriteLine("\nLast name: " + LastName);
            if (LastNameRegex.IsMatch(LastName))
                Console.WriteLine("Valid Last Name");
            else
                Console.WriteLine("Invalid Last Name");
        }
        public void ValidateUserEmail(string Email)
        {
            Console.WriteLine("\nEmail: " + Email);
            if (UserEmail.IsMatch(Email))
                Console.WriteLine("Valid Email ID");
            else
                Console.WriteLine("Invalid Email ID");
        }
        public void ValidateMobileNumber(string UserMobile)
        {
            Console.WriteLine("\nMobile Number: " + UserMobile);
            if (MobileNumber.IsMatch(UserMobile))
                Console.WriteLine("Valid Mobile Number");
            else
                Console.WriteLine("Invalid Mobile Number");
        }
        public void ValidatePassword(string Password)
        {
            Console.WriteLine("\nPassword : " + Password);
            if (UserPassword.IsMatch(Password))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
    }
}
