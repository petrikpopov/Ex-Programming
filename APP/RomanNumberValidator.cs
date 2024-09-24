using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public static class RomanNumberValidator
    {
        public static bool Validate(string input)
        {
            return CheckSymbols(input) && CheckDigitRatios(input) && CheckSequence(input);
        }

        public static bool IsValidRomanDigit(char digit)
        {
            return digit == 'N' || digit == 'I' || digit == 'V' || digit == 'X' ||
                   digit == 'L' || digit == 'C' || digit == 'D' || digit == 'M';
        }

        private static bool CheckSymbols(string input)
        {
            foreach (char c in input)
            {
                if (!IsValidRomanDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckDigitRatios(string input)
        {
            return true;
        }

        private static bool CheckSequence(string input)
        {
            return true;
        }

        public static bool IsValidRomanString(string roman)
        {
            foreach (char c in roman)
            {
                if (!IsValidRomanDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
