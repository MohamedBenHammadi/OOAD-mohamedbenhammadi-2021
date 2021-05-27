using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLibrary
{
    public class Ontelening
    {
        // connectiestring
        static string connString = ConfigurationManager.AppSettings["connString"];

      

        public int Id { get; set; }
        public DateTime DatumUit { get; set; }

        public DateTime UiterstedatumIn { get; set; }

        public DateTime WerkelijkeDatumIn { get; set; }

        public int? BoeteBedrag { get; set; }

        public DateTime? BoeteVoldaanOp { get; set; }

        public int ExemplaarId { get; set; }


        public int Lidnummer { get; set; }



        public Ontelening()
        {

        }
        

        public Ontelening(int id,DateTime dtmut, DateTime uitD, DateTime werkelijkeD, int? boete, DateTime? boeteVol, int exmplrId, int lidid)
        {
            Id = id;
            DatumUit = dtmut;
            UiterstedatumIn = uitD;
            WerkelijkeDatumIn = werkelijkeD;
            BoeteBedrag = boete;
            BoeteVoldaanOp = boeteVol;
            ExemplaarId = exmplrId;
            Lidnummer = lidid;
        }




        public override string ToString()
        {
            return $" datum uit: {DatumUit.ToShortDateString()}, datum in: {UiterstedatumIn.ToShortDateString()}, exemplaar id: {ExemplaarId} ";
        }


        public static List<Ontelening> AllOnteleningen()
        {
            List<Ontelening> ontelening = new List<Ontelening>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Ontlening", conn);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    DateTime datumUit = Convert.ToDateTime(reader["datum_uit"]);
                    DateTime uitersteDatumIn = Convert.ToDateTime(reader["uiterste_datum_in"]);
                    DateTime WrkelijkeDatumIn = Convert.ToDateTime(reader["werkelijke_datum_in"]);
                    int?  boeteBedrag = reader["boete_bedrag"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["boete_bedrag"]);
                    DateTime? boeteVoldaan = reader["boete_voldaan_op"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["boete_voldaan_op"]);
                    int exemplaarid = Convert.ToInt32(reader["exemplaar_id"]);
                    int lidnummer = Convert.ToInt32(reader["lid_lidnummer"]);

                    ontelening.Add(new Ontelening(id, datumUit, uitersteDatumIn, WrkelijkeDatumIn, boeteBedrag, boeteVoldaan, exemplaarid, lidnummer));
                }
            }
            return ontelening;
        }


        public static Ontelening OntelingID(int id)
        {
           
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Ontlening where id = @id", conn);
                comm.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comm.ExecuteReader();

                reader.Read();

                    id = Convert.ToInt32(reader["id"]);
                    DateTime datumUit = Convert.ToDateTime(reader["datum_uit"]);
                    DateTime uitersteDatumIn = Convert.ToDateTime(reader["uiterste_datum_in"]);
                    DateTime WrkelijkeDatumIn = Convert.ToDateTime(reader["werkelijke_datum_in"]);
                    int? boeteBedrag = reader["boete_bedrag"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["boete_bedrag"]);
                    DateTime? boeteVoldaan = reader["boete_voldaan_op"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["boete_voldaan_op"]);
                    int exemplaarid = Convert.ToInt32(reader["exemplaar_id"]);
                    int lidnummer = Convert.ToInt32(reader["lid_lidnummer"]);

                return new Ontelening(id, datumUit, uitersteDatumIn, WrkelijkeDatumIn, boeteBedrag, boeteVoldaan, exemplaarid, lidnummer);
            }
           
        }

        public void OntleningTerug()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("delete from Ontlening where id = @id", conn);
                comm.Parameters.AddWithValue("@id", Id);
                comm.ExecuteNonQuery();
            }
        }

        public void OntleenLid(int itemid, int lid)
        {
            //Exemplaar exemplaar = Exemplaar.ExemplaarId(itemid);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("insert into  Ontlening (datum_uit, uiterste_datum_in, exemplaar_id, lid_lidnummer) values (@datumuit,@datumin,@exemplaarid,@lidnummer)", conn);
                comm.Parameters.AddWithValue("@datumuit", DateTime.Now);
                comm.Parameters.AddWithValue("@datumin", DateTime.Now.AddMonths(1));
                comm.Parameters.AddWithValue("@exemplaarid", 2);
                comm.Parameters.AddWithValue("@lidnummer", 137);
                comm.ExecuteNonQuery();
            }
        }

        //public static int AantalOntleningenId(int id)
        //{
        //     int aantalOnt;

        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand("SELECT count(exemplaar_id) FROM Ontlening where exemplaar_id = @exemplaarId group by exemplaar_id", conn);
        //        comm.Parameters.AddWithValue(" @exemplaarId", id);
        //        //if (aantalOnt == null)
        //        //{
        //        //    comm.ExecuteScalar();
        //        //}
        //        //aantalOnt = comm.ExecuteScalar() == null ? 0 : (Int32)comm.ExecuteScalar();
        //    }
        //    //return aantalOnt;
        //}

    }
}
