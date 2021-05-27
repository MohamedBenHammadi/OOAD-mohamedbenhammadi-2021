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

        public Leden()
        {

        }
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

        public void LidAanpassen(int lidnummer, string voornaam, string achternaam, DateTime geboortedtm, string nummer, string straat, int postcode, string gemeente, DateTime vervaldatum, string gsm)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(
                    @"  update Lid set lidnummer=@lidnummer, Voornaam=@voornaam , Achternaam=@achternaam,Geboortedatum =@geboortedatum, nummer=@nummer, straat = @straat, postcode =@postcode,Gemeente=@gemeente, Vervaldatum_lidkaart=@vervaldatum, Gsm = @gsm  where lidnummer = @lidnummer ", conn);
       
                comm.Parameters.AddWithValue("@lidnummer", lidnummer);
                comm.Parameters.AddWithValue("@voornaam", voornaam);
                comm.Parameters.AddWithValue("@achternaam", achternaam);
                comm.Parameters.AddWithValue("@geboortedatum", geboortedtm);
                comm.Parameters.AddWithValue("@nummer", nummer);
                comm.Parameters.AddWithValue("@straat", straat);
                comm.Parameters.AddWithValue("@postcode", postcode);
                comm.Parameters.AddWithValue("@gemeente", gemeente);
                comm.Parameters.AddWithValue("@vervaldatum", vervaldatum);
                comm.Parameters.AddWithValue("@gsm", gsm);
                comm.ExecuteNonQuery();
            }
        }
        public void VervalDatumAanpassen(int id, DateTime vervaldatum)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(
                    @"  update Lid set  Vervaldatum_lidkaart=@vervaldatum  where lidnummer = @lidnummer ", conn);

               
                comm.Parameters.AddWithValue("@vervaldatum", vervaldatum);
                comm.Parameters.AddWithValue("@lidnummer", id);
                comm.ExecuteNonQuery();
            }
        }


        public void Verwijderklant()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("delete from Lid where lidnummer = @par1", conn);
                comm.Parameters.AddWithValue("@par1", Lidnummer);
                comm.ExecuteNonQuery();
            }
        }




        public void Voegklant(int lidnummer, string voornaam, string achternaam, DateTime geboortedtm, string nummer, string straat, int postcode, string gemeente, DateTime vervaldatum, string gsm)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(
                    @"   insert into Lid (lidnummer, Voornaam, Achternaam,Geboortedatum, nummer, Straat, postcode,Gemeente,Vervaldatum_lidkaart,gsm ) values (@lidnummer,@voornaam,@achternaam,@geboortedatum,@nummer,@straat ,@postcode,@gemeente, @vervaldatum, @gsm) ", conn);

                comm.Parameters.AddWithValue("@lidnummer", lidnummer);
                comm.Parameters.AddWithValue("@voornaam", voornaam);
                comm.Parameters.AddWithValue("@achternaam", achternaam);
                comm.Parameters.AddWithValue("@geboortedatum", geboortedtm);
                comm.Parameters.AddWithValue("@nummer", nummer);
                comm.Parameters.AddWithValue("@straat", straat);
                comm.Parameters.AddWithValue("@postcode", postcode);
                comm.Parameters.AddWithValue("@gemeente", gemeente);
                comm.Parameters.AddWithValue("@vervaldatum", vervaldatum);
                comm.Parameters.AddWithValue("@gsm", gsm);
                comm.ExecuteNonQuery();
            }
        }

        public static bool LoginLid(int lidnummer)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comn = new SqlCommand(" SELECT * FROM Lid WHERE lidnummer=@lidnummer ", conn);
                comn.Parameters.AddWithValue("@lidnummer", lidnummer);
                SqlDataReader reader = comn.ExecuteReader();

                if (reader.HasRows)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


       



    }
}
