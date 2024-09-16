using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public static class RomanNumberValidator
    {
        public static bool IsValidRomanDigit(char digit)
        {
            return digit == 'N' || digit == 'I' || digit == 'V' || digit == 'X' ||
                   digit == 'L' || digit == 'C' || digit == 'D' || digit == 'M';
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
