using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;

namespace EmpClassLibrary
{
    public class Medewerker
    {
        //connectiestring
        static string connString = ConfigurationManager.AppSettings["connString"];


        //propreties
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public int CodePasje { get; set; }



        public string Paswoord { get; set; }

        //constructor
        public Medewerker()
        {


        }

        

        public Medewerker(int id, string vm, string am)
        {
            Id = id;
            Voornaam = vm;
            Achternaam = am;
        }

        public Medewerker(int id, string vm, string am, int codePasje, string pasw) : this(id , vm,am)
        {
            CodePasje = codePasje;
            Paswoord = pasw;
        }

        //methodes 

        public static bool LoginMedewerker(string passwoord, string codePasje)
        {
        
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comn = new SqlCommand(" SELECT * FROM Medewerker WHERE code_pasje=@code_pasje  AND paswoord=@paswoord ", conn);
                comn.Parameters.AddWithValue("@code_pasje", codePasje);
                comn.Parameters.AddWithValue("@paswoord", passwoord);
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



        public static List<Medewerker> GetAll()
        {
            List<Medewerker> medewerker = new List<Medewerker>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Medewerker", conn);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string naam = Convert.ToString(reader["voornaam"]);
                    string familienaam = Convert.ToString(reader["achternaam"]);
                    int telefoon= Convert.ToInt32(reader["code_pasje"]);
                    string paswoord = Convert.ToString(reader["paswoord"]);
                    medewerker.Add(new Medewerker(id, naam, familienaam, telefoon, paswoord));
                }

            }
            return medewerker;
        }


    }


}
