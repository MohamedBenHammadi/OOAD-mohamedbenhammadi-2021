using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLibrary
{
    public class Leden
    {

        static string connString = ConfigurationManager.AppSettings["connString"];

        public int Lidnummer { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public DateTime Geboortedatum { get; set; }
        public string Straat { get; set; }

        public string Nummer { get; set; }

        public int Postcode { get; set; }

        public string Gemeente { get; set; }

        public DateTime VervaldatumLidkaart { get; set; }

        public string Gsm { get; set; }


        //construcotr met info over de lid
        public Leden( int lidnummer, string vn, string achtn, string gsm, DateTime vrvldatum)
        {
            Lidnummer = lidnummer;
            Voornaam = vn;
            Achternaam = achtn;
            Gsm = gsm;
            VervaldatumLidkaart = vrvldatum;
        }


        // constructor met personelijke info van lid
        public Leden(int lidnummer,string vn, string achtn, string gsm, DateTime gbrtdatum, string straat, string nmr, int pstcode, string gemeente, DateTime vrvldatum ) : this(lidnummer, vn, achtn, gsm, vrvldatum)
        {
            Geboortedatum = gbrtdatum;
            Straat = straat;
            Nummer = nmr;
            Postcode = pstcode;
            Gemeente = gemeente;

        }

        //methoden

        //public static List<Leden> GetLidByName(string naam)
        //{
        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand("SELECT * FROM Lid", conn);
        //        SqlDataReader reader = comm.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            int lidnummer = Convert.ToInt32(reader["id"]);
        //            string vvornaam = Convert.ToString(reader["voornaam"]);
        //            string achternaam = Convert.ToString(reader["achternaam"]);
        //            DateTime geboortedatum = Convert.ToInt32(reader["code_pasje"]);
        //            string straat = Convert.ToString(reader["paswoord"]);
        //            medewerker.Add(new Medewerker(id, naam, familienaam, telefoon, paswoord));
        //        }

        //    }
        //    return medewerker;
        //}



        public override string ToString()
        {
            return $"{Lidnummer} {Voornaam}, {Achternaam}";
        }


        public static List<Leden> LijstLeden()
        {
            List<Leden> klant = new List<Leden>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Lid", conn);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["lidnummer"]);
                    string voornaam = Convert.ToString(reader["Voornaam"]);
                    string achternaam = Convert.ToString(reader["Achternaam"]);
                    DateTime geboortedatum = Convert.ToDateTime(reader["Geboortedatum"]);
                    string straat = Convert.ToString(reader["Straat"]);
                    string nummer = Convert.ToString(reader["nummer"]);
                    int postcode = Convert.ToInt32(reader["postcode"]);
                    string gemeente = Convert.ToString(reader["Gemeente"]);
                    DateTime vervaldatum = Convert.ToDateTime(reader["Vervaldatum_lidkaart"]);
                    string gsm = Convert.ToString(reader["Gsm"]);

                    klant.Add(new Leden(id, voornaam, achternaam, gsm, geboortedatum, straat, nummer, postcode, gemeente,vervaldatum));
                }

            }
            return klant;
        }

        public static Leden GetKlanttId(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Lid WHERE lidnummer = @lidnummer", conn);
                comm.Parameters.AddWithValue("@lidnummer", id);
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();

                id = Convert.ToInt32(reader["lidnummer"]);
                string voornaam = Convert.ToString(reader["Voornaam"]);
                string achternaam = Convert.ToString(reader["Achternaam"]);
                DateTime geboortedatum = Convert.ToDateTime(reader["Geboortedatum"]);
                string straat = Convert.ToString(reader["Straat"]);
                string nummer = Convert.ToString(reader["nummer"]);
                int postcode = Convert.ToInt32(reader["postcode"]);
                string gemeente = Convert.ToString(reader["Gemeente"]);
                DateTime vervaldatum = Convert.ToDateTime(reader["Vervaldatum_lidkaart"]);
                string gsm = Convert.ToString(reader["Gsm"]);
                return new Leden(id, voornaam, achternaam, gsm, geboortedatum, straat, nummer, postcode, gemeente, vervaldatum);
            }
        }





    }
}
