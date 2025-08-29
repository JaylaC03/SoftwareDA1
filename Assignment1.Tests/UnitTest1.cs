using Assignment1.library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnlyLowercase_ShouldBeIneligible()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("abc");
            Assert.AreEqual("INELIGIBLE", result);
        }

        [TestMethod]
        public void OnlyUppercase_ShouldBeIneligible()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("ABC");
            Assert.AreEqual("INELIGIBLE", result);
        }

        [TestMethod]
        public void OnlyDigits_ShouldBeIneligible()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("123");
            Assert.AreEqual("INELIGIBLE", result);
        }

        [TestMethod]
        public void OnlySpecialChars_ShouldBeIneligible()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("@#$");
            Assert.AreEqual("INELIGIBLE", result);
        }

        [TestMethod]
        public void LowercaseAndUppercase_ShouldBeMedium()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("abcDEF");
            Assert.AreEqual("INELIGIBLE", result);
        }

        [TestMethod]
       public void LowerUpperAndDigits_ShouldBeMedium()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("abcDEF123");
            Assert.AreEqual("MEDIUM", result);
        }
        [TestMethod]
        public void LowerUpperAndSpecial_ShouldBeMedium()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("abcDEF@#");
            Assert.AreEqual("MEDIUM", result);
        }
        [TestMethod]
        public void AllCriteriaMet_ShouldBeStrong()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("abcDEF123@#");
            Assert.AreEqual("STRONG", result);
        }
        [TestMethod]
        public void EmptyPassword_ShouldBeIneligible()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("");
            Assert.AreEqual("INELIGIBLE", result);
        }

        [TestMethod]
        public void SingleCharacter_ShouldBeIneligible()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("a");
            Assert.AreEqual("WEAK", result);
        }

        [TestMethod]
        public void TooShortPassword_ShouldBeIneligible()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("aB1!");
            Assert.AreEqual("INELIGIBLE", result);
        }

        [TestMethod]
        public void StrongButTooShort_ShouldBeIneligible()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("aB1!c"); // meets all criteria, but < 8 chars
            Assert.AreEqual("INELIGIBLE", result);
        }

        [TestMethod]
        public void StrongAndLongEnough_ShouldBeStrong()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("aB1!cdef");
            Assert.AreEqual("STRONG", result);
        }

    }
}
