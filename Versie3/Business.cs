using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie3
{
    class Business
    {
        private Persistence pers;

        private List<LidK> _LidK;
        public List<LidK> LidKs
        {
            get { return _LidK; }
            set { _LidK = value; }
        }

        public Business()
        {
            pers = new Persistence();
            LidKs = pers.getLedenFromDB();
            aankopen = pers.GetAankopenFromDB();
            Leidingks = pers.getLeidingFromDB();
            materialen = pers.GetMaterialenFromDB();
            klusjes = pers.GetKlusjesFromDB();
        
       }

        public List<string> getLeden()
        {
            List<string> result = new List<string>();

            foreach (LidK item in LidKs)
            {
                result.Add(item.ToString());
            }

            return result;
        }

        public void voegToe(string pstrnaam, string pstrgeboorte, string pstrmedisch, string pstradres, string pstrmail, string pstrtak, string pstrachternaam)
        {
            LidK l = new LidK(pstrnaam, pstrgeboorte, pstrmedisch, pstradres, pstrmail, pstrtak, pstrachternaam);
            pers.addLeden(l);

        }

        private List<AankoopK> _aankopen;
        public List<AankoopK> aankopen
        {
            get { return _aankopen; }
            set { _aankopen = value; }
        }
        
        public List<string> getAankopen()
        {
            List<string> result = new List<string>();

            foreach (AankoopK item in aankopen)
            {
                result.Add(item.ToString());
            }
            return result;
        }

        public void voegToe(double pPrijs, int pAantal, string pVoorwerp)
        {
            AankoopK a = new AankoopK(pPrijs, pAantal, pVoorwerp);
            pers.addAankoop(a);
        }

        private List<LeidingK> _LeidingK;
        public List<LeidingK> Leidingks
        {
            get { return _LeidingK; }
            set { _LeidingK = value; }
        }

        public List<string> getLeiding()
        {
            List<string> result = new List<string>();

            foreach (LeidingK item in Leidingks)
            {
                result.Add(item.ToString());
            }

            return result;
        }

        public void voegToe(string pnaam, string pachternaam, string ptak, string pstart, string phoofd)
        {
            LeidingK l = new LeidingK(pnaam, pachternaam, ptak, pstart, phoofd);
            pers.addLeiding(l);

        }

        private List<MateriaalK> _materialen;
        public List<MateriaalK> materialen
        {
            get { return _materialen; }
            set { _materialen = value; }
        }

        public List<string> getMaterialen()
        {
            List<string> result = new List<string>();

            foreach (MateriaalK item in materialen)
            {
                result.Add(item.ToString());
            }
            return result;
        }

        public void voegToe(string pNaam, int pAantal, string pBeschikbaarheid)
        {
            MateriaalK m = new MateriaalK(pNaam, pAantal, pBeschikbaarheid);
            pers.addMateriaal(m);
        }

        private List<KlusjeK> _klusjes;
        public List<KlusjeK> klusjes
        {
            get { return _klusjes; }
            set { _klusjes = value; }
        }

        public List<string> getKlusjes()
        {
            List<string> result = new List<string>();

            foreach (KlusjeK item in klusjes)
            {
                result.Add(item.ToString());
            }
            return result;
        }










    }
}
