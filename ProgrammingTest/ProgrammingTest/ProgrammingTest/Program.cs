using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoGodt b = new BoGodt();

            b.PopulateApartmentList();
            Console.WriteLine(b.GetTotalPrice());
        }
    }
}
