using APP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class RomanNumberValidatorTest
    {
        [TestMethod]
        public void IsValidRomanDigitTest()
        {
            Assert.IsTrue(RomanNumberValidator.IsValidRomanDigit('I'));
            Assert.IsTrue(RomanNumberValidator.IsValidRomanDigit('V'));
            Assert.IsTrue(RomanNumberValidator.IsValidRomanDigit('X'));
            Assert.IsFalse(RomanNumberValidator.IsValidRomanDigit('A'));
            Assert.IsFalse(RomanNumberValidator.IsValidRomanDigit('1'));
        }

        [TestMethod]
        public void IsValidRomanStringTest()
        {
            Assert.IsTrue(RomanNumberValidator.IsValidRomanString("IV"));
            Assert.IsTrue(RomanNumberValidator.IsValidRomanString("MCMXC"));
            Assert.IsFalse(RomanNumberValidator.IsValidRomanString("ABC"));
            Assert.IsFalse(RomanNumberValidator.IsValidRomanString("123"));
        }
    }
}
