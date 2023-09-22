using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class Floor
    {
        protected byte sqm;  // square metres
        protected byte sqmPrice;
        protected short price;

        protected const byte SQM_PRICE = 179;
        // 30 M UNDERLAG 400 KR.

        public Floor(byte sqM)
        {
            price = (short)(SQM_PRICE * sqM);
            price += (short)((sqM % 30) * 400);
        }

        public short Price()
        {
            return price;
        }
    }
}
