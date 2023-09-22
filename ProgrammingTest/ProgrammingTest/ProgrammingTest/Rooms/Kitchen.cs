using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class Kitchen : Room
    {
        protected const int PRICE = 37899;
        protected const float ROOMS_MARKUP = 1.17F;

        public Kitchen(byte roomAmount, Window w)
        {
            price = PRICE;

            for (int i = 0; i < roomAmount; i++)
            {
                price *= (int)ROOMS_MARKUP;
            }

            window = w;

            door = new BackDoor();

            price += window.Price() + door.Price();
        }

        public string Print()
        {
            return $"Kitchen \nPrice: {price} \n";
        }

        public int Price()
        {
            return price;
        }
    }
}
