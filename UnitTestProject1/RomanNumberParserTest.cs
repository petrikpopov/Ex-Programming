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
    public class RomanNumberParserTest
    {
        [TestMethod]
        public void ParseValidNumeralsTest()
        {
            Assert.AreEqual(4, RomanNumberParser.Parse("IV"));
            Assert.AreEqual(1990, RomanNumberParser.Parse("MCMXC"));
            Assert.AreEqual(0, RomanNumberParser.Parse("N"));
            Assert.AreEqual(5, RomanNumberParser.Parse("V"));
        }

        [TestMethod]
        public void ParseInvalidNumeralsTest()
        {
            Assert.ThrowsException<ArgumentException>(() => RomanNumberParser.Parse("IIII"));
            Assert.ThrowsException<ArgumentException>(() => RomanNumberParser.Parse("ABC"));
            Assert.ThrowsException<ArgumentException>(() => RomanNumberParser.Parse(""));
        }

        [TestMethod]
        public void DigitValueTest()
        {
            Assert.AreEqual(1, RomanNumberParser.DigitValue('I'));
            Assert.AreEqual(5, RomanNumberParser.DigitValue('V'));
            Assert.AreEqual(1000, RomanNumberParser.DigitValue('M'));

            var ex = Assert.ThrowsException<ArgumentException>(
                () => RomanNumberParser.DigitValue('A'));
            StringAssert.Contains(ex.Message, "Invalid Roman numeral character");
        }
    }
}
