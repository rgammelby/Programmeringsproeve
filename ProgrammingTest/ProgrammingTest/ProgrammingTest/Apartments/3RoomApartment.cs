using ProgrammingTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class _3RoomApartment : Apartment
    {
        protected const byte SQM = 70;
        protected const byte ROOMS = 3;

        public _3RoomApartment(BackDoor bD, Bathroom bR, Window kW)
        {
            rooms = new List<Room>();
            sqm = SQM;
            floor = new Floor(SQM);
            kitchen = new Kitchen(ROOMS, kW);
            fd = new FrontDoor();
            bd = bD;
            br = bR;
        }

        public override string Print()
        {
            return $"Renovation cost for 3 room apartment \nFloors: {floor.Price()} kr. \n" +
                $"Kitchen: {kitchen.Price()} kr. \n" +
                $"Front door: {fd.Price()} kr. \n" +
                $"Back door: {bd.Price()} kr. \n" +
                $"Bathroom: {br.Price()} kr. \n" +
                $"Total: {floor.Price() + kitchen.Price() + fd.Price() + bd.Price()} kr. \n";
        }

        public override double Price()
        {
            return floor.Price() + kitchen.Price() + fd.Price() + bd.Price() + bd.Price() + br.Price();
        }
    }
}
