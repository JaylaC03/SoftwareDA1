using Assignment1.library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnlyLowercase_ShouldBeWeak()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("abc");
            Assert.AreEqual("WEAK", result);
        }

        [TestMethod]
        public void OnlyUppercase_ShouldBeWeak()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("ABC");
            Assert.AreEqual("WEAK", result);
        }

        [TestMethod]
        public void OnlyDigits_ShouldBeWeak()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("123");
            Assert.AreEqual("WEAK", result);
        }

        [TestMethod]
        public void OnlySpecialChars_ShouldBeWeak()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("@#$");
            Assert.AreEqual("WEAK", result);
        }

        [TestMethod]
        public void LowercaseAndUppercase_ShouldBeMedium()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("abcDEF");
            Assert.AreEqual("MEDIUM", result);
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
        public void SingleCharacter_ShouldBeWeak()
        {
            PasswordChecker checker = new PasswordChecker();
            string result = checker.CheckPassword("a");
            Assert.AreEqual("WEAK", result);
        }
    }
}
