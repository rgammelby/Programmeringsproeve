using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class LivingRoom : Room
    {
        public LivingRoom(byte rooms, byte manufacturer, string wColour)
        {
            if (manufacturer == 0)
            {
                if (rooms >= 4)
                {
                    window = new VindbjergWindow(3, false, wColour);
                }
                else
                {
                    window = new VindbjergWindow(2, true, wColour);
                }
            }
            else if (manufacturer == 1)
            {
                if (rooms >= 4)
                {
                    window = new KHFWindow(3, false, wColour);
                }
                else
                {
                    {
                        window = new KHFWindow(2, true, wColour);
                    }
                }

                door = new BackDoor();

                price = (short)(window.Price() + door.Price());
            }
        }
    }
}
