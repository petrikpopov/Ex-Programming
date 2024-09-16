using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public static class RomanNumberParser
    {
        public static int Parse(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Input string cannot be empty.");
            }

            if (!RomanNumberValidator.IsValidRomanString(value))
            {
                throw new ArgumentException("Input string contains invalid Roman numeral characters.");
            }

            int result = 0;
            int prevDigit = 0;

            for (int i = value.Length - 1; i >= 0; i--)
            {
                char c = value[i];
                int digit = DigitValue(c);

                result += digit < prevDigit ? -digit : digit;
                prevDigit = digit;
            }

            return result;
        }
        public static int DigitValue(char digit)
        {
            switch (digit)
            {
                case 'N': return 0;
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default:
                    throw new ArgumentException($"Invalid Roman numeral character: {digit}");
            }
        }
    }
}
