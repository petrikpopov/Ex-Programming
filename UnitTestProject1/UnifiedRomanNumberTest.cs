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
    public class UnifiedRomanNumberTest
    {
        private List<TestCase<string, int>> testCases;

        [TestInitialize]
        public void SetUp()
        {
            testCases = new List<TestCase<string, int>>
            {
                new TestCase<string, int>("Test IV", "IV", 4, () =>
                {
                    Assert.AreEqual(4, RomanNumberParser.Parse("IV"));
                }),
                new TestCase<string, int>("Test MCMXC", "MCMXC", 1990, () =>
                {
                    Assert.AreEqual(1990, RomanNumberParser.Parse("MCMXC"));
                }),
                new TestCase<string, int>("Test N", "N", 0, () =>
                {
                    Assert.AreEqual(0, RomanNumberParser.Parse("N"));
                }),
                new TestCase<string, int>("Test Invalid Characters ABC", "ABC", 0, () =>
                {
                    Assert.ThrowsException<ArgumentException>(() => RomanNumberParser.Parse("ABC"));
                }),
                new TestCase<string, int>("Test Invalid Numeral IIII", "IIII", 0, () =>
                {
                    Assert.ThrowsException<ArgumentException>(() => RomanNumberParser.Parse("IIII"));
                })
            };
        }

        [TestMethod]
        public void RunAllTests()
        {
            foreach (var testCase in testCases)
            {
                testCase.Execute();
            }
        }
    }
}
