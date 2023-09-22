using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class Bathroom : Room
    {
        public Bathroom(byte manufacturer, string wColour)
        {
            if (manufacturer == 0)
            {
                window = new VindbjergWindow(1, true, wColour);
            }
            else if (manufacturer == 1)
            {
                window = new KHFWindow(1, true, wColour);
            }

            door = new BackDoor();

            price = (short)(window.Price() + door.Price());
        }

        public short Price()
        {
            return price;
        }
    }
}
