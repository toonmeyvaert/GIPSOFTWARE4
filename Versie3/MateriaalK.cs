using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie3
{
    class MateriaalK
    {
        private string strNaam, strBeschikbaarheid;
        private int intAantal;

        public string naam
        {
            get { return strNaam; }
            set { strNaam = value; }
        }
        public int aantal
        {
            get { return intAantal; }
            set { intAantal = value; }
        }
        public string beschikbaarheid
        {
            get { return strBeschikbaarheid; }
            set { strBeschikbaarheid = value; }
        }

        public MateriaalK(string pstrNaam, int pintAantal, string pstrBeschikbaarheid)
        {
            strNaam = pstrNaam;
            intAantal = pintAantal;
            strBeschikbaarheid = pstrBeschikbaarheid;
        }

        public override string ToString()
        {
            return strNaam + " " + intAantal + " " + strBeschikbaarheid;
        }
    }
}
