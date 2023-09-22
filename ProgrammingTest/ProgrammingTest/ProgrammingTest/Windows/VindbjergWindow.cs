using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    internal class VindbjergWindow : Window
    {
        protected const byte VINDBJERG_GUARANTEE = 25;
        protected const float VINDBJERG_MARKUP = 1.25F;

        public VindbjergWindow(byte bPanes, bool bMatted, string sColour)
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

            guarantee = VINDBJERG_GUARANTEE;
            price *= (short)VINDBJERG_MARKUP;
        }

        public override bool IsMatted()
        {
            return matted;
        }

        public override string Print()
        {
            return $"Vindbjerg Window \nPanes: {panes} \nMatted: {matted} \nColour: {colour} \nGuarantee: {guarantee} years \nPrice: {price} kr. \n";
        }

        public override short Price()
        {
            return price;
        }
    }
}
