using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class BoGodt
    {
        private List<Apartment> _apartments;
        private double _price;
        private const double BUDGET = 550000000;

        public BoGodt()
        {
            _apartments = new List<Apartment>();
        }

        public void PopulateApartmentList()
        {
            for (int i = 0; i < 47; i++)
            {
                _apartments.Add(new _5RoomApartment(new BackDoor(), new Bathroom(1, "Blue"), new VindbjergWindow(1, false, "White")));
            }

            for (int i = 0; i < 97; i++)
            {
                _apartments.Add(new _4RoomApartment(new BackDoor(), new Bathroom(1, "Blue"), new VindbjergWindow(1, false, "White")));
            }

            for (int i = 0; i < 167; i++)
            {
                _apartments.Add(new _3RoomApartment(new BackDoor(), new Bathroom(1, "Blue"), new VindbjergWindow(1, false, "White")));
            }

            for (int i = 0; i < 235; i++)
            {
                _apartments.Add(new _2RoomApartment(new BackDoor(), new Bathroom(1, "Blue"), new VindbjergWindow(1, false, "White")));
            }

            for (int i = 0; i < 368; i++)
            {
                _apartments.Add(new _1RoomApartment(new BackDoor(), new Bathroom(1, "Blue"), new VindbjergWindow(1, false, "White")));
            }
        }

        public void CalculateTotalPrice()
        {
            foreach (Apartment a in _apartments)
            {
                _price += a.Price();
            }
        }

        public double GetTotalPrice()
        {
            CalculateTotalPrice();

            return _price;
        }
    }
}
