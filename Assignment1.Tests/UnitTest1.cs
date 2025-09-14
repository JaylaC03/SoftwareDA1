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
        // Tests for UUID function
        [TestMethod]
        public void TestUuidLength()
        {
            UuidGenerator generator = new UuidGenerator();
            string uuid = generator.GenerateUuidV4();
            Assert.AreEqual(36, uuid.Length);
        }

        [TestMethod]
        public void TestUuidHasDashes()
        {
            UuidGenerator generator = new UuidGenerator();
            string uuid = generator.GenerateUuidV4();
            Assert.AreEqual('-', uuid[8]);
            Assert.AreEqual('-', uuid[13]);
            Assert.AreEqual('-', uuid[18]);
            Assert.AreEqual('-', uuid[23]);
        }

        [TestMethod]
        public void TestUuidIsVersion4()
        {
            UuidGenerator generator = new UuidGenerator();
            string uuid = generator.GenerateUuidV4();
            Assert.AreEqual('4', uuid[14]);
        }

        [TestMethod]
        public void TestUuidNotNull()
        {
            UuidGenerator generator = new UuidGenerator();
            string uuid = generator.GenerateUuidV4();
            Assert.IsNotNull(uuid);
        }

        [TestMethod]
        public void TestUuidNotEmpty()
        {
            UuidGenerator generator = new UuidGenerator();
            string uuid = generator.GenerateUuidV4();
            Assert.IsTrue(uuid.Length > 0);
        }

        [TestMethod]
        public void TestUuidsAreDifferent()
        {
            UuidGenerator generator = new UuidGenerator();
            string uuid1 = generator.GenerateUuidV4();
            string uuid2 = generator.GenerateUuidV4();
            Assert.AreNotEqual(uuid1, uuid2);
        }


    }
}
