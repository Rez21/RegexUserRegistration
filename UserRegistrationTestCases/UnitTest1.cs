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
        public void Email_TestValidation()
        {
            string expectedEmail = "prasad.ban@gmail.com";
            string actualEmail = userValidation.ValidateUserEmail("prasad.ban@gmail.com");
            Assert.AreEqual(expectedEmail, actualEmail);
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