using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class FrontDoor : Door
    {
        protected const short PRICE = 6465;

        public FrontDoor()
        {
            price = PRICE;
        }

        public override string Print()
        {
            return $"Front door \nPrice: {price} kr. \n";
        }

        public override short Price()
        {
            return price;
        }
    }
}
