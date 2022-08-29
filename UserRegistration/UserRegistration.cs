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
    }
}
