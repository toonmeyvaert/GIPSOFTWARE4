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
        private string strVerdeeling;
        private string strPlanning;

        public string soort
        {
            get { return strSoort; }
            set { value = strSoort; }
        }
        public string verdeeling
        {
            get { return strVerdeeling; }
            set { value = strVerdeeling; }
        }
        public string planning
        {
            get { return strPlanning; }
            set { value = strPlanning; }
        }

        public KlusjeK(string pstrSoort, string pstrVerdeeling, string pstrPlanning)
        {
            strSoort = pstrSoort;
            strVerdeeling = pstrVerdeeling;
            strPlanning = pstrPlanning;
        }
    }
}
