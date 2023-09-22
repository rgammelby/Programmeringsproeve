using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    /// <summary>
    /// The class <c>BackDoor</c> describes a Back Door object. Inherited from the Door class.
    /// Since the (non-fire resistant) back door is the cheapest door, this is what "Bo Godt" will be using for internal apartment doors.
    /// </summary>
    internal class BackDoor : Door
    {
        protected bool fireResistant;
        protected string resistance;

        const short PRICE = 4879;

        protected enum FireResistance { BD40, BD60 }

        public BackDoor()
        {
            fireResistant = false;
            price = PRICE;
        }

        public BackDoor(byte type)
        {
            fireResistant = true;
            resistance = ((FireResistance)type).ToString();

            price = (short)Math.Ceiling(PRICE * 1.58);

            if (type == 0)
                price *= (short)0.85;
        }

        public override string Print()
        {
            return $"Back door \nFire resistant: {fireResistant} \nResistance type: {resistance} \nPrice: {price} kr. \n";
        }

        public override short Price()
        {
            return price;
        }
    }
}
