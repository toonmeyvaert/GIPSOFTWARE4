using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie3
{
    class AankoopK
    {
        private string strVoorwerp;
        private int intAantal;
        private double dblPrijs;

        public string voorwerp
        {
            get { return strVoorwerp; }
            set { strVoorwerp = value; }
        }
        public int aantal
        {
            get { return intAantal; }
            set { intAantal = value; }
        }
        public double prijs
        {
            get { return dblPrijs; }
            set { dblPrijs = value; }
        }

        public AankoopK(double pdblPrijs, int pintAantal, string pstrVoorwerp)
        {
            intAantal = pintAantal;
            dblPrijs = pdblPrijs;
            strVoorwerp = pstrVoorwerp;
        }

        public override string ToString()
        {
            return strVoorwerp + " " + intAantal + " " + dblPrijs;
        }
        //dickpick ffff

    }
}
