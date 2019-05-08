using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie3
{
    class Business
    {
        private Persistence pers ;
        private List<LidK> _LidK;
        public List<LidK> LidKs
        {
            get { return _LidK; }
            set { _LidK = value; }
        }

        public Business()
        {
            pers = new Persistence();
            aankopen = pers.GetAankopenFromDB();
            LidKs = pers.getLedenFromDB();
            Leidingks = pers.getLeidingFromDB();
            materialen = pers.GetMaterialenFromDB();
           
            klusjes = pers.GetKlusjesFromDB();
        }
        //leden
        public List<LidK> getLeden()
        {
            List<LidK> result = new List<LidK>();
            return LidKs;
        }
        public void voegToe(string pstrnaam, string pstrgeboorte, string pstrmedisch, string pstradres, string pstrmail, string pstrtak, string pstrachternaam)
        {
            LidK l = new LidK(pstrnaam, pstrgeboorte, pstrmedisch, pstradres, pstrmail, pstrtak, pstrachternaam);
            pers.addLeden(l);

        }
        //aankopen
        private List<AankoopK> _aankopen;
        public List<AankoopK> aankopen
        {
            get { return _aankopen; }
            set { _aankopen = value; }
        }        
        public List<AankoopK> getAankopen()
        {
            List<AankoopK> result = new List<AankoopK>();
            return aankopen;
        }
        public void voegToe(double pPrijs, int pAantal, string pVoorwerp)
        {
            AankoopK a = new AankoopK(pPrijs, pAantal, pVoorwerp);
            pers.addAankoop(a);
        }
        //leiding
        private List<LeidingK> _LeidingK;
        public List<LeidingK> Leidingks
        {
            get { return _LeidingK; }
            set { _LeidingK = value; }
        }
        public List<LeidingK> getLeiding()
        {
            List<LeidingK> result = new List<LeidingK>();
            return Leidingks;
        }
        public void voegToe(string pnaam, string pachternaam, string ptak, string pstart, string phoofd)
        {
            LeidingK l = new LeidingK(pnaam, pachternaam, ptak, pstart, phoofd);
            pers.addLeiding(l);

        }
        //materiaal
        private List<MateriaalK> _materialen;
        public List<MateriaalK> materialen
        {
            get { return _materialen; }
            set { _materialen = value; }
        }
        public List<MateriaalK> getMaterialen()
        {
            List<MateriaalK> result = new List<MateriaalK>();
            return materialen;
        }
        public void voegToe(string pNaam, int pAantal, string pBeschikbaarheid)
        {
            MateriaalK m = new MateriaalK(pNaam, pAantal, pBeschikbaarheid);
            pers.addMateriaal(m);
        }
        //Klusjes
        private List<KlusjeK> _klusjes;
        public List<KlusjeK> klusjes
        {
            get { return _klusjes; }
            set { _klusjes = value; }
        }
        public List<KlusjeK> getKlusjes()
        {
            List<KlusjeK> result = new List<KlusjeK>();
            return klusjes;
        }
        public void voegToe(string pSoort, string pverantwoordelijke, string pPlanning)
        {
            KlusjeK k = new KlusjeK(pSoort, pverantwoordelijke, pPlanning);
            pers.addKlusje(k);
        }

        public accLeiding logIn(string naam)
        {
            return pers.logIn(naam);
        }
        public bool tryLogIn(string naam, string ww)
        {
            if (pers.loginCorrect(naam, ww))
            { return true; } else { return false; }
        }






    }
}
