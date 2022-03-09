using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registration_Regex_Test;

namespace Registration_Test
{

    [TestClass]
    public class Testing
    {
        RegistrationPattern registrationPattern = new RegistrationPattern();

        [TestMethod]
        public void GivenRight_FirstName_ReturnTrue()
        {
            bool actual = registrationPattern.ValidateFirstName("Rahul");
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrong_FirstName_ReturnFalse()
        {
            bool actual = registrationPattern.ValidateFirstName("raj");
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GivenRight_LastName_ReturnTrue()
        {
            bool actual = registrationPattern.ValidateLastName("Kohli");
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrong_LastName_ReturnFalse()
        {
            bool actual = registrationPattern.ValidateLastName("Li");
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenRight_Email_ReturnTrue(string EmialId)
        {
            bool actual = registrationPattern.ValidateEmail(EmialId);
            //"abc@yahoo.com"
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc@.com.my")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void GivenWrong_Email_ReturnFalse(string EmialId)
        {
            bool actual = registrationPattern.ValidateEmail(EmialId);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GivenRight_mobileNo_ReturnTrue()
        {
            bool actual = registrationPattern.ValidateMobileNo("91 9876543210");
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrong_mobileNo_ReturnFalse()
        {
            bool actual = registrationPattern.ValidateMobileNo("987654321");
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void GivenRight_Password_ReturnTrue()
        {
            bool actual = registrationPattern.ValidatePassword("abcDE#1234");
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrong_Password_ReturnFalse()
        {
            bool actual = registrationPattern.ValidatePassword("abCD12");
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }
    }
}