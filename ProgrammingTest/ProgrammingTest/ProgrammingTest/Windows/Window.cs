using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal abstract class Window
    {
        protected byte panes;  // 1-3
        protected bool matted;
        protected short price;
        protected string colour;
        protected byte guarantee;  // years

        protected const short ONE_PANE = 1879;
        protected const short TWO_PANES = 2798;
        protected const short THREE_PANES = 4678;

        protected const float MATTED_MARKUP = 1.30F;

        protected enum Manufacturers { Vindbjerg, KHF }

        public abstract bool IsMatted();

        public abstract string Print();

        public abstract short Price();
    }
}
