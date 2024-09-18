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
    public class RomanNumberTest
    {
        [TestMethod]
        public void RomanToShortTest()
        {
            var roman = new RomanNumber("IV");
            Assert.AreEqual((short)4, roman.ToShort());
        }

        [TestMethod]
        public void RomanToByteTest()
        {
            var roman = new RomanNumber("V");
            Assert.AreEqual((byte)5, roman.ToByte());
        }

        [TestMethod]
        public void RomanToLongTest()
        {
            var roman = new RomanNumber("MCMXC");
            Assert.AreEqual(1990L, roman.ToLong());
        }

        [TestMethod]
        public void RomanToIntTest()
        {
            var roman = new RomanNumber("L");
            Assert.AreEqual(50, roman.ToInt());
        }

        [TestMethod]
        public void RomanToFloatTest()
        {
            var roman = new RomanNumber("X");
            Assert.AreEqual(10f, roman.ToFloat());
        }

        [TestMethod]
        public void RomanToDoubleTest()
        {
            var roman = new RomanNumber("IX");
            Assert.AreEqual(9.0, roman.ToDouble());
        }

        [TestMethod]
        public void RomanToByteOverflowTest()
        {
            var roman = new RomanNumber("MCMXC");
            Assert.ThrowsException<OverflowException>(() => roman.ToByte());
        }

        [TestMethod]
        public void RomanToShortOverflowTest()
        {
            var roman = new RomanNumber("MMMM");
            Assert.ThrowsException<OverflowException>(() => roman.ToShort());
        }
    }
}
