namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserValidation userRegexCheck = new UserValidation();
            string FirstName = "Raghav";
            userRegexCheck.ValidateFirstName(FirstName);
        }
    }
}