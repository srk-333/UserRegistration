using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace MsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateFirstName("Saurav");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestFirstName_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateFirstName("Sa");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateFirstName("saurav");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestLastName_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateFirstName("Kumar");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestLastName_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateFirstName("Ka");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateFirstName("kumar");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateMobileNumber("91 9934731585");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateMobileNumber("9134731585");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateMobileNumber("23 9934731585");
            Assert.AreEqual(excepted, actual1);
            var actual2 = UserRegister.ValidateMobileNumber("23 993473158555");
            Assert.AreEqual(excepted, actual2);
        }
    }
}