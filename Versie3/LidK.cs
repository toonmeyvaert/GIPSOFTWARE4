using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie3
{
    class LidK
    {
        private string strNaam;
        private string strGeboorte;
        private string strMedische;
        private string strAdres;
        private string strEmailOuder;
        private string strTak;
        private string strAchternaam;

        public string naam
        {
            get { return strNaam; }
            set { strNaam = value; }
        }

        public string geboorte
        {
            get { return strGeboorte; }
            set { strGeboorte = value; }
        }

        public string medisch
        {
            get { return strMedische; }
            set { strMedische = value; }
        }

        public string adres
        {
            get { return strAdres; }
            set { strAdres = value; }
        }

        public string email
        {
            get { return strEmailOuder; }
            set { strEmailOuder = value; }
        }

        public string tak
        {
            get { return strTak; }
            set { strTak = value; }
        }

        public string achternaam
        {
            get { return strAchternaam; }
            set { strAchternaam = value; }
        }


        public LidK(string pstrnaam, string pstrgeboorte, string pstrmedisch, string pstradres, string pstrmail, string pstrtak, string pstrachternaam)
        {
            strNaam = pstrnaam;
            strGeboorte = pstrgeboorte;
            strMedische = pstrmedisch;
            strAdres = pstradres;
            strEmailOuder = pstrmail;
            strTak = pstrtak;
            strAchternaam = pstrachternaam;
        }

        public override string ToString()
        {
            return strNaam + " " + strAchternaam + " " + strGeboorte + " " + strMedische + " " + strAdres + " " + strEmailOuder + " " + strTak;
        }

    }
}
