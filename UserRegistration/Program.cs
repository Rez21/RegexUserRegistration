namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserValidation userRegexCheck = new UserValidation();
            string FirstName = "Raghav";
            string LastName = "ban";
            string Email = "raghav12@gmail.com";
            string UserMobile = "91 9125687953";
            string Password = "Mypassword9@";
            string[] Emails = { "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            userRegexCheck.ValidateFirstName(FirstName);
            userRegexCheck.ValidateLastName(LastName);
            userRegexCheck.ValidateUserEmail(Email);
            userRegexCheck.ValidateMobileNumber(UserMobile);  
            userRegexCheck.ValidatePassword(Password);

            foreach(string s in Emails)
            {
                userRegexCheck.ValidateUserEmail(s);
            }
        }
    }
}