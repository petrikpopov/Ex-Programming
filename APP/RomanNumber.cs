using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class RomanNumber
    {
        private readonly int _value;

        public RomanNumber(int value)
        {
            _value = value;
        }

        public int Value { get { return _value; } }

        public static RomanNumber Parse(string value)
        {
            int result = 0;
            int prevDigit = 0;

            for (int i = value.Length - 1; i >= 0; i--)
            {
                char c = value[i];
                try
                {
                    if (!IsValidRomanDigit(c)) // использую
                    {
                        throw new ArgumentException($"Invalid character '{c}' at position {i}.");
                    }

                    int digit = DigitValue(c);
                    result += digit < prevDigit ? -digit : digit;
                    prevDigit = digit;
                }
                catch (ArgumentException ex)
                {
                    throw new ArgumentException($"Invalid character '{c}' at position {i}.", ex);
                }
            }

            return new RomanNumber(result);
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

        public static bool IsValidRomanDigit(char digit) // новый метод с проверкой
        {
             return digit == 'N' || digit == 'I' || digit == 'V' || digit == 'X' || digit == 'L' || digit == 'C' || digit == 'D' || digit == 'M';
        }
    }

}
