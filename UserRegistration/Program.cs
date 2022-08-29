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
            userRegexCheck.ValidateFirstName(FirstName);
            userRegexCheck.ValidateLastName(LastName);
            userRegexCheck.ValidateUserEmail(Email);
        }
    }
}