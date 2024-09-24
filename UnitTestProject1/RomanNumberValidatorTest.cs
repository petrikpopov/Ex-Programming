using APP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class RomanNumberValidatorTest
    {
        [TestMethod]
        public void TestCheckSymbols()
        {
            var methodInfo = typeof(RomanNumberValidator)
                .GetMethod("CheckSymbols", BindingFlags.NonPublic | BindingFlags.Static);

            Assert.IsNotNull(methodInfo);

            bool result = (bool)methodInfo.Invoke(null, new object[] { "IV" });
            Assert.IsTrue(result);

            result = (bool)methodInfo.Invoke(null, new object[] { "ABC" });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCheckDigitRatios()
        {
            var methodInfo = typeof(RomanNumberValidator)
                .GetMethod("CheckDigitRatios", BindingFlags.NonPublic | BindingFlags.Static);

            Assert.IsNotNull(methodInfo);

            bool result = (bool)methodInfo.Invoke(null, new object[] { "MCMXC" });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckSequence()
        {
            var methodInfo = typeof(RomanNumberValidator)
                .GetMethod("CheckSequence", BindingFlags.NonPublic | BindingFlags.Static);

            Assert.IsNotNull(methodInfo);

            bool result = (bool)methodInfo.Invoke(null, new object[] { "IX" });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidate()
        {
            bool isValid = RomanNumberValidator.Validate("IV");
            Assert.IsTrue(isValid);

            isValid = RomanNumberValidator.Validate("IIII");
            Assert.IsFalse(isValid);
        }
    }
}
