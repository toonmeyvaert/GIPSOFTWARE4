using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie3
{
    class KlusjeK
    {
        private int intSoort;
        private int intVerdeeling;
        private int intPlanning;

        public int soort
        {
            get { return intSoort; }
            set { value = intSoort; }
        }
        public int verdeeling
        {
            get { return intVerdeeling; }
            set { value = intVerdeeling; }
        }
        public int planning
        {
            get { return intPlanning; }
            set { value = intPlanning; }
        }

        public KlusjeK(int pintSoort, int pintVerdeeling, int pintPlanning)
        {
            intSoort = pintSoort;
            intVerdeeling = pintVerdeeling;
            intPlanning = pintPlanning;
        }
    }
}
