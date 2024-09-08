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

            foreach (char c in value.Reverse())
            {
                int digit = DigitValue(c);
                result += digit < prevDigit ? -digit : digit;
                prevDigit = digit;
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
                default: return 1000;
            }
        }

    }
}
