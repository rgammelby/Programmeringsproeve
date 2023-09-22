using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class KHFWindow : Window
    {
        public const byte KFH_GUARANTEE = 10;

        public KHFWindow(byte bPanes, bool bMatted, string sColour)
        {
            panes = bPanes;

            if (panes == 1)
                price = ONE_PANE;
            else if (panes == 2)
                price = TWO_PANES;
            else if (panes == 3)
                price = THREE_PANES;

            matted = bMatted;

            if (matted)
            {
                price *= (short)MATTED_MARKUP;
            }

            colour = sColour;

            guarantee = KFH_GUARANTEE;
        }
        public override bool IsMatted()
        {
            return matted;
        }

        public override string Print()
        {
            return $"KHF Window \nPanes: {panes} \nMatted: {matted} \nColour: {colour} \nGuarantee: {guarantee} years \nPrice: {price} kr. \n";
        }

        public override short Price()
        {
            return price;
        }
    }
}
