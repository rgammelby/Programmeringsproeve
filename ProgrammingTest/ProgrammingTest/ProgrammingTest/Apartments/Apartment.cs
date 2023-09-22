using ProgrammingTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal abstract class Apartment
    {
        protected int price;
        protected byte sqm;  // square metres
        protected Floor floor;  // floor type (laminate/wood)
        protected Kitchen kitchen;
        protected FrontDoor fd;
        protected BackDoor bd;
        protected Bathroom br;
        protected LivingRoom lr;

        public abstract string Print();

        public abstract double Price();
    }
}
