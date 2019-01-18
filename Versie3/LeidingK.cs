using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie3
{
    class LeidingK
    {
        private string strNaam, strAchternaam, strTak, strStart, strHoofdleiding;

        public string naam
        {
            get { return strNaam; }
            set { strNaam = value; }
        }

        public string achternaam
        {
            get { return strAchternaam; }
            set { strAchternaam = value; }
        }

        public string tak
        {
            get { return strTak; }
            set { strTak = value; }
        }

        public string start
        {
            get { return strStart; }
            set { strStart = value; }
        }

        public string hoofd
        {
            get { return strHoofdleiding; }
            set { strHoofdleiding = value; }
        }

        public LeidingK(string pnaam, string pachternaam, string ptak, string pstart, string phoofd)
        {
            strNaam = pnaam;
            strAchternaam = pachternaam;
            strStart = pstart;
            strTak = ptak;
            strHoofdleiding = phoofd;
        }

        public override string ToString()
        {
            return strNaam + strAchternaam + strStart + strTak + strHoofdleiding;
        }

    }
}
