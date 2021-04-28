using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegex;

namespace UserRegexMS_UnitTestFile
{
    [TestClass]
    public class RegexMethod_UnitTest
    {
        [TestMethod]
        public void TestValidatePinCode()
        {   //Arrange
            RegexPattern regex = new RegexPattern();
            //Act
            bool result = regex.ValidatePinCode("460551");
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestValidateFirstName()
        {
            RegexPattern regex = new RegexPattern();
            bool resultFirstName = regex.ValidateFirstName("Sailesh");
            Assert.IsTrue(resultFirstName);
        }
        [TestMethod]
        public void TestValidateLastName()
        {
            RegexPattern regex = new RegexPattern();
            bool resultLastName = regex.ValidateLastName("Chauhan");
            Assert.IsTrue(resultLastName);
        }
        [TestMethod]
        public void TestValidateMobileFormat()
        {
            RegexPattern regex = new RegexPattern();
            bool resultMobileFormat = regex.ValidateMobileFormat("+91 8085701918");
            Assert.IsTrue(resultMobileFormat);
        }
        [TestMethod]
        public void TestCatchInValidatePassword()
        {
            RegexPattern regex = new RegexPattern();
            bool resultInValidatePassword = regex.ValidateMobileFormat("Surendra123#");
            Assert.IsFalse(resultInValidatePassword);
        }
        [TestMethod]
        public void TestValidateEmail()
        {
            EmailSampleFile emailsample = new EmailSampleFile();
            foreach (var Email in emailsample.validEmails)
            {
                bool resultValidateEmail = emailsample.ValidateEmail(Email);
                Assert.IsTrue(resultValidateEmail);
            }
        }
        [TestMethod]
        public void TestInvalidateEmail()
        {
            EmailSampleFile emailSample = new EmailSampleFile();
            foreach(var Email in emailSample.inValidEmails)
            {
                bool resultInvalidateEmail = emailSample.ValidateEmail(Email);
                Assert.IsFalse(resultInvalidateEmail);
            }
        }
    }
}
