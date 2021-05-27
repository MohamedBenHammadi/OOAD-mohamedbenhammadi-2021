using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLibrary
{
    public class Exemplaar
    {
        // connectiestring
        static string connString = ConfigurationManager.AppSettings["connString"];


        public int Id { get; set; }
        public int Nummer { get; set; }

        public int Item_id { get; set; }




        public Exemplaar(int nummer, int itemid)
        {
            Nummer = nummer;
            Item_id = itemid;
        }

        public Exemplaar(int id, int nummer, int itemId)
        {
            Id = id;
            Nummer = nummer;
            Item_id = itemId;
        }


        public static int CheckStock(int id)
        {

                int aantal = 0;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand("spCheckStock", conn);
                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@item_id", id);
                    SqlDataReader reader = comm.ExecuteReader();
                reader.Close();
                    aantal = (Int32)comm.ExecuteScalar();
                }
                return aantal;
            
        }

        //public static Exemplaar ExemplaarId(int itemid)
        //{
        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand("SELECT * FROM Exemplaar where item_id = @itemid", conn);
        //        comm.Parameters.AddWithValue("@itemid", itemid);
        //        SqlDataReader reader = comm.ExecuteReader();
        //        reader.Read();

        //        itemid = Convert.ToInt32(reader["item_id"]);
        //        int nummer = Convert.ToInt32(reader["nummer"]);
        //        return new Exemplaar(itemid, nummer);
        //    }
        //}



    }
}
