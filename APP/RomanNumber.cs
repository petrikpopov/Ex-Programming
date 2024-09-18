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

        public RomanNumber(string roman)
        {
            _value = RomanNumberParser.Parse(roman);
        }

        public short ToShort()
        {
            if (_value > short.MaxValue || _value < short.MinValue)
                throw new OverflowException("Value is out of range for short.");
            return (short)_value;
        }

        public byte ToByte()
        {
            if (_value > byte.MaxValue || _value < byte.MinValue)
                throw new OverflowException("Value is out of range for byte.");
            return (byte)_value;
        }

        public long ToLong()
        {
            return _value;
        }

        public int ToInt()
        {
            return _value;
        }

        public float ToFloat()
        {
            return _value;
        }

        public double ToDouble()
        {
            return _value;
        }
    }

}
