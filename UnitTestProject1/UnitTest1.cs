using APP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
   /* [TestClass]
    public class RomanNumberTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            RomanNumber rn = RomanNumber.Parse("");
            rn = null;
            Assert.IsNotNull(rn, "Parse result is not null!");
            Assert.AreEqual(2, rn.Value, "Zero testing");
        }

        [TestMethod]
        public void ParseTest()
        {
            Dictionary<String, int> testCases = new Dictionary<String, int>()
            {
                { "N", 0},
                { "I", 1},
                { "II", 2},
                { "III", 3},
                { "IIII", 4},
                { "V", 5},
                { "X", 10},
                { "D", 500},
                { "IV", 4},
                { "VI", 6},
                { "XI", 11},
                { "IX", 9},
                { "MM", 2000},
                { "MCM", 1900},
                //HM
                { "XL", 40},
                { "XC", 90},
                { "CD", 400},
                { "CMII", 902},
                { "DCCCC", 900},
                { "CCCC", 400},
                { "XIXIIII", 23},
                { "XXXXX", 50},
                { "DDMD", 1500},


            };
            foreach (var testCase in testCases)
            {
                RomanNumber rn = RomanNumber.Parse(testCase.Key);
                Assert.IsNotNull(rn, $"Parse result of '{testCase.Key}' is not null");
                Assert.AreEqual(
                    testCase.Value,
                    rn.Value,
                    $"Parse '{testCase.Key}' => {testCase.Value}"
                    );
            }
        }

        [TestMethod]
        public void DigitValueChar()
        {
            Dictionary<char, int> testCases = new Dictionary<char, int>()
             {
                 {'N', 0},
                 {'I', 1},
                 {'V', 5},
                 {'X', 10},
                 {'L', 50},
                 {'C', 100},
                 {'D', 500},
                 {'M', 1000},
             };
            foreach (var testCase in testCases)
            {
                Assert.AreEqual(testCase.Value,
                    RomanNumber.DigitValue(testCase.Key),
                    $"{testCase.Key} => {testCase.Value}"
                    );
            }

            // HomeW_05.09.2024

            char[] excCases = { 'N', '1', 'x', 'i', '&' };

            foreach (var digit in excCases)
            {
                var ex = Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.DigitValue(digit),
                    $"Expected ArgumentException for digit: '{digit}'"
                );

                StringAssert.Contains(ex.Message, $"{digit}",
                    $"Message should mention the invalid character '{digit}', but it was: {ex.Message}");
                StringAssert.Contains(ex.Message, $"{nameof(RomanNumber)}",
                    $"Message should mention the class '{nameof(RomanNumber)}' but it was: {ex.Message}");
                StringAssert.Contains(ex.Message, $"{nameof(RomanNumber.DigitValue)}",
                    $"Message should mention the method '{nameof(RomanNumber.DigitValue)}' but it was: {ex.Message}");
                StringAssert.Contains(ex.Message, "argument",
                    $"Message should contain the word 'argument', but it was: {ex.Message}");
            }

            // HomeW_09.09.2024
            Dictionary<string, char> invalidStrings = new Dictionary<string, char>()
            {
                { "SDR", 'S' },
                { "VXLQ", 'Q' },
                { "MMMCMZ", 'Z' },
                {"XXL", 'L'},
                {"IIV", 'I'},
                {"VV", 'V'},
            };

            foreach (var testCase in invalidStrings)
            {
                var ex = Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse(testCase.Key),
                    $"Expected ArgumentException for value '{testCase.Key}'"
                );

                char invalidChar = testCase.Value;
                int position = testCase.Key.IndexOf(invalidChar);

                StringAssert.Contains(ex.Message, $"{invalidChar}",
                    $"Message should mention the invalid character '{invalidChar}', but it was: {ex.Message}");
                StringAssert.Contains(ex.Message, $"position {position}",
                    $"Message should mention the position of '{invalidChar}' at position {position}, but it was: {ex.Message}");
            }


            // HomeW_10.09.2024
            string[] exCases3 = { "IIV", "XXL", "VV", "LL", "DD" };

            foreach (var testCase in exCases3)
            {
                var ex = Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse(testCase),
                    $"Expected ArgumentException for incorrect numeral sequence '{testCase}'"
                );

                StringAssert.Contains(ex.Message, "invalid sequence",
                    $"Message should explain the invalid numeral sequence, but it was: {ex.Message}");
            }
        }
    }*/
}
