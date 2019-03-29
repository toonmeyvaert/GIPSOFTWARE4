using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Versie3
{
    class Persistence
    {
        private string _connectie;
        private MySqlConnection conn;

        public Persistence()
        {
            _connectie = "server=ID191774_6itngip17.db.webhosting.be;user id=ID191774_6itngip17;database=ID191774_6itngip17;password=WQVU3Cti";
            conn = new MySqlConnection(_connectie);
        }

        public List<LidK> getLedenFromDB()
        {
            List<LidK> lijst = new List<LidK>();


            MySqlCommand cmd = new MySqlCommand("select * from lid", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                LidK l = new LidK(dataReader["NaamLid"].ToString(), (dataReader["Geboortejaar"].ToString()), (dataReader["MedischeFiche"].ToString()), (dataReader["adres"].ToString()),(dataReader["EmailOuder"].ToString()),(dataReader["Tak"].ToString()), dataReader["Achternaam"].ToString());
                lijst.Add(l);
            }
            conn.Close();
            return lijst;
        }

        public void addLeden(LidK item)
        {
           

            MySqlCommand cmd = new MySqlCommand("insert into lid (NaamLid,GeboorteJaar,MedischeFiche,adres,EmailOuder,Tak,Achternaam) values ('" + item.naam + "','" + item.geboorte + "','" + item.medisch + "','" + item.adres +"','"+item.email + "','" + item.tak + "','" + item.achternaam +  "')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<AankoopK> GetAankopenFromDB()
        {
            List<AankoopK> lijst = new List<AankoopK>();


            MySqlCommand cmd = new MySqlCommand("select * from aankoop", conn);

            conn.Open();
            MySqlDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                AankoopK a = new AankoopK(Convert.ToDouble(datareader["Prijs"]), Convert.ToInt32(datareader["Aantal"]), datareader["Voorwerp"].ToString());
                lijst.Add(a);
            }
            conn.Close();
            return lijst;
        }

        public void addAankoop(AankoopK item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into aankoop (Prijs,Aantal,Voorwerp) values (" + item.prijs + "," + item.aantal + ",'" + item.voorwerp + "')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<LeidingK> getLeidingFromDB()
        {
            List<LeidingK> lijst = new List<LeidingK>();


            MySqlCommand cmd = new MySqlCommand("select * from leiding", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                LeidingK l = new LeidingK(dataReader["Naam"].ToString(), (dataReader["Achternaam"].ToString()), (dataReader["Tak"].ToString()), (dataReader["Startleiding"].ToString()), (dataReader["Hoofdleiding"].ToString()));
                lijst.Add(l);
            }
            conn.Close();
            return lijst;
        }

        public void addLeiding(LeidingK item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into leiding (Naam,Tak,StartLeiding,Hoofdleiding,Achternaam) values ('" + item.naam + "','" + item.tak + "','" + item.start + "','" + item.hoofd + "','" + item.achternaam + "')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<MateriaalK> GetMaterialenFromDB()
        {
            List<MateriaalK> lijst = new List<MateriaalK>();


            MySqlCommand cmd = new MySqlCommand("select * from materiaal", conn);

            conn.Open();
            MySqlDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                MateriaalK m = new MateriaalK(datareader["Naam"].ToString(), Convert.ToInt32(datareader["Aantal"]), datareader["Beschikbaarheid"].ToString());
                lijst.Add(m);
            }
            conn.Close();
            return lijst;
        }

        public void addMateriaal(MateriaalK item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into materiaal (Naam,Aantal,Beschikbaarheid) values ('" + item.naam + "'," + item.aantal + ",'" + item.beschikbaarheid + "')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<KlusjeK> GetKlusjesFromDB()
        {
            List<KlusjeK> lijst = new List<KlusjeK>();

            MySqlCommand cmd = new MySqlCommand("select * from klusje", conn);

            conn.Open();
            MySqlDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                KlusjeK k = new KlusjeK(datareader["SoortenKlusje"].ToString(),datareader["Taakverdeling"].ToString(), datareader["Planning"].ToString());
            }
            conn.Close();
            return lijst;
        }

        public void addKlusje(KlusjeK item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into klusje (SoortenKlusje,Taakverdeling,Planning) values ('" + item.soort + "'," + item.verdeeling + ",'" + item.planning + "')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
