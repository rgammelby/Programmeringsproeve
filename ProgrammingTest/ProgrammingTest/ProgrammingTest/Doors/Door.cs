using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal abstract class Door
    {
        protected short price;

        public abstract string Print();

        public abstract short Price();
    }
}
