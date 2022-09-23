using UserRegistration;
using NUnit.Framework;
namespace UserRegistrationTestCases
{
    public class Tests
    {
        UserValidation userValidation;
        [SetUp]
        public void Setup()
        {
            userValidation = new UserValidation();
        }

        [Test]
        public void FirstName_TestValidation()
        {
            string expectedFirstName = "Prasad";
            string actual = userValidation.ValidateFirstName("Prasad");
            Assert.AreEqual(expectedFirstName, actual);
        }


        [Test]
        public void LastName_TestValidation()
        {
            string expectedLastName = "Ban";
            string actualLastName = userValidation.ValidateLastName("Ban");
            Assert.AreEqual(expectedLastName, actualLastName);
        }

        [Test]
        [TestCase("abc.100@yahoo.com", "^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$")]
        [TestCase("abc-100@yahoo.com", "^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$")]
        [TestCase("abc.100@yahoo.com.au", "^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$")]
        [TestCase("abc+100@yahoo.com", "^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$")]

        public void Email_TestValidation(string expected, string pattern)
        {
            
            string actualEmail = userValidation.ValidateUserEmail(expected);
            Assert.AreEqual(expected, actualEmail);
        }

        [Test]
        public void Mobile_TestValidationCheck()
        {
            string expected = "918563254725";
            string actual = userValidation.ValidateMobileNumber(expected);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void User_Password_test_Valid_Check()
        {
            string expcted = "Xyz@12";
            string actual = userValidation.ValidatePassword(expcted);
            Assert.AreEqual(expcted, actual);
        }
    }
}