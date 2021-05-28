using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLibrary
{
    public class Reservatie
    {

        static string connString = ConfigurationManager.AppSettings["connString"];

        public int Id { get; set; }

        public DateTime Datumreservatie { get; set; }

        public int Exemplaarid { get; set; }


        public int Lidlidnummer { get; set; }


        public Reservatie()
        {

        }

        public Reservatie(int id, DateTime dtmreservatie, int exemplaarid, int lidnumr)
        {
            Id = id;
            Datumreservatie = dtmreservatie;
            Exemplaarid = exemplaarid;
            Lidlidnummer = lidnumr;
        }


        public override string ToString()
        {
            return $" datum reserveratie: {Datumreservatie.ToShortDateString()}, exemplaar id: {Exemplaarid}, lidnummer: {Lidlidnummer} ";
        }

        public static Reservatie ReservatieId(int reserid)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Reservatie where id = @id", conn);
                comm.Parameters.AddWithValue("@id", reserid);
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();

                int id = Convert.ToInt32(reader["id"]);
                DateTime datum_reservatie = Convert.ToDateTime(reader["datum_reservatie"]);
                int exemplaarId = Convert.ToInt32(reader["exemplaar_id"]);
                int lidnummer = Convert.ToInt32(reader["lid_lidnummer"]);

                return new Reservatie(id, datum_reservatie, exemplaarId, lidnummer);
            }
        }

        public static List<Reservatie> LijstReservatie(int klantid)
        {
            List<Reservatie> klant = new List<Reservatie>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM  Reservatie where lid_lidnummer = @lidnummer", conn);
                comm.Parameters.AddWithValue("@lidnummer", klantid);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    DateTime datum_reservatie = Convert.ToDateTime(reader["datum_reservatie"]);
                    int exemplaarId = Convert.ToInt32(reader["exemplaar_id"]);
                    int lidnummer = Convert.ToInt32(reader["lid_lidnummer"]);


                    klant.Add(new Reservatie(id, datum_reservatie, exemplaarId, lidnummer));
                }
            }
            return klant;
        }
        public void VoegReservatie(DateTime datumReservatie, int exemplaarid, int lidnummer)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(
                    @"insert into Reservatie (datum_reservatie, exemplaar_id, lid_lidnummer) values (@datumr,@exemplaarid,@lidnummer)", conn);
                comm.Parameters.AddWithValue("@datumr", datumReservatie);
                comm.Parameters.AddWithValue("@exemplaarid", exemplaarid);
                comm.Parameters.AddWithValue("@lidnummer", lidnummer);

                comm.ExecuteScalar();
            }
        }
        public void VerwijderReservatie()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("delete from Reservatie where id = @id", conn);
                comm.Parameters.AddWithValue("@id", Id);
                comm.ExecuteNonQuery();
            }
        }

        public static List<Reservatie> LijsReservatieZonderId()
        {
            List<Reservatie> reservaties = new List<Reservatie>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Reservatie", conn);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    DateTime datum_reservatie = Convert.ToDateTime(reader["datum_reservatie"]);
                    int exemplaarId = Convert.ToInt32(reader["exemplaar_id"]);
                    int lidnummer = Convert.ToInt32(reader["lid_lidnummer"]);

                    reservaties.Add(new Reservatie(id, datum_reservatie, exemplaarId, lidnummer));
                }

            }
            return reservaties;
        }
    }
}
