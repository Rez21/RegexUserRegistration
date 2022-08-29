namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserValidation userRegexCheck = new UserValidation();
            string FirstName = "Raghav";
            string LastName = "ban";
            userRegexCheck.ValidateFirstName(FirstName);
            userRegexCheck.ValidateLastName(LastName);
        }
    }
}