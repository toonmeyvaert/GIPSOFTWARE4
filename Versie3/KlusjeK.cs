using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie3
{
    class KlusjeK
    {
        private string strSoort;
        private string strVerantwoordelijke;
        private string strPlanning;

        public string soort
        {
            get { return strSoort; }
            set { value = strSoort; }
        }
        public string verantwoordelijke
        {
            get { return strVerantwoordelijke; }
            set { value = strVerantwoordelijke; }
        }
        public string planning
        {
            get { return strPlanning; }
            set { value = strPlanning; }
        }

        public KlusjeK(string pstrSoort, string pstrVerantwoordelijke, string pstrPlanning)
        {
            strSoort = pstrSoort;
            strVerantwoordelijke = pstrVerantwoordelijke;
            strPlanning = pstrPlanning;
        }
    }
}
