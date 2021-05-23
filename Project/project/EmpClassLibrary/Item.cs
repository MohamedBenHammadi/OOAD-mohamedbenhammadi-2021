using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace EmpClassLibrary
{
    public class Item
    {
        // connectiestring
       static string connString = ConfigurationManager.AppSettings["connString"];

        public int Id { get; set; }

        public string Titel { get; set; }

        public string Beschrijving { get; set; }

        public string Uitgeverij { get; set; }

        public BitmapImage Coverfoto { get; set; }
        public int LeeftijdVan { get; set; }

        public int LeeftijdTot { get; set; }
        public string Taal { get; set; }

        //constructor


        public Item()
        {
        }
        public Item(string titel, BitmapImage coverfoto)
        {
           
            Titel = titel;
            Coverfoto = coverfoto;
        }

        public Item(int id, string titel, string beschrijving)
        {
            Id = id;
            Titel = titel;
            Beschrijving = beschrijving;
        }

        public Item(int id, string titel, string beschrijving, string uitgeverij, int leeftijdVan, int leeftijdTot, string taal) : this(id, titel, beschrijving)
        {
            Uitgeverij = uitgeverij;
            LeeftijdVan = leeftijdVan;
            LeeftijdTot = leeftijdTot;
            Taal = taal;
        }
        public Item(int id, BitmapImage cover, string titel, string beschrijving, string uitgevrij, int leeftvan, int leeftijdtot, string taal )
        {
            Id = id;
            Coverfoto = cover;
            Titel = titel;
            Beschrijving = beschrijving;
            Uitgeverij = uitgevrij;
            LeeftijdVan = leeftvan;
            LeeftijdTot = leeftijdtot;
            Taal = taal;
        }


        public static Item GetElementId(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Item WHERE ID = @id", conn);
                comm.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();

                id = Convert.ToInt32(reader["id"]);
                string titel = Convert.ToString(reader["titel"]);
                string beschrijving = Convert.ToString(reader["beschrijving"]);
                string uitgeverij = Convert.ToString(reader["uitgeverij"]);
                int leeftijdvan = Convert.ToInt32(reader["leeftijd_van"]);
                int leeftijdTot = Convert.ToInt32(reader["leeftijd_tot"]);
                string taal = Convert.ToString(reader["taal"]);
                return new Item(id, titel, beschrijving, uitgeverij, leeftijdvan, leeftijdTot, taal);
            }
        }

        //methodes
        public static List<Item> GetAll()
        {
            List<Item> items = new List<Item>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Item", conn);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {

                    BitmapImage cover = new BitmapImage();
                    cover.BeginInit();
                    cover.CacheOption = BitmapCacheOption.OnLoad;
                    cover.StreamSource = new System.IO.MemoryStream((byte[])reader["coverfoto"]);
                    cover.EndInit();


                    int id = Convert.ToInt32(reader["id"]);
                    string titel = Convert.ToString(reader["titel"]);
                    string beschrijving = Convert.ToString(reader["beschrijving"]);
                    string uitgeverij = Convert.ToString(reader["uitgeverij"]);
                    int leeftijdVan = Convert.ToInt32(reader["leeftijd_van"]);
                    int leeftijdTot = Convert.ToInt32(reader["leeftijd_tot"]);
                    string taal = Convert.ToString(reader["taal"]);
                    items.Add(new Item(id,cover,titel,beschrijving,uitgeverij,leeftijdVan,leeftijdTot,taal));
                }
               

            }
            return items;
        }

        public override string ToString()
        {
            return $"{Titel}";
        }

        public void VoegItem(string titel, string bes )
        {

        }

        public void ItemAanpassen(int id, string titel, string coverFoto, string besch, string uitgeverij, int leeftijdV, int leeftijdT, string taal)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(
                    @"  update Item set titel=@titel, coverfoto=@coverFoto beschrijving=@beschrijving, uitgeverij=@uitgeverij, leeftijd_van=@leeftijdVan, leeftijd_tot=@LeeftijdTot,taal=@Taal where id = @Id ", conn);
                byte[] cover = File.ReadAllBytes(coverFoto);
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@titel", titel);
                comm.Parameters.AddWithValue("@titel", titel);
                comm.Parameters.AddWithValue("@beschrijvingB", besch);
                comm.Parameters.AddWithValue("@uitgeverij", uitgeverij );
                comm.Parameters.AddWithValue("@pleeftijdVan", leeftijdV);
                comm.Parameters.AddWithValue("@LeeftijdTot", leeftijdT);
                comm.Parameters.AddWithValue("@Taal", taal);
                comm.ExecuteNonQuery();
            }
        }

        public void VerwijderItem()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("delete from Item where id = @par1", conn);
                comm.Parameters.AddWithValue("@par1", Id);
                comm.ExecuteNonQuery();
            }
        }


        public void VoegItem(int id, string titel, string coverFoto, string besch, string uitgeverij, int leeftijdV, int leeftijdT, string taal)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(
                    @"  update Item set titel=@titel, coverfoto=@coverFoto beschrijving=@beschrijving, uitgeverij=@uitgeverij, leeftijd_van=@leeftijdVan, leeftijd_tot=@LeeftijdTot,taal=@Taal where id = @Id ", conn);
                byte[] cover = File.ReadAllBytes(coverFoto);
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@titel", titel);
                comm.Parameters.AddWithValue("@titel", titel);
                comm.Parameters.AddWithValue("@beschrijvingB", besch);
                comm.Parameters.AddWithValue("@uitgeverij", uitgeverij);
                comm.Parameters.AddWithValue("@pleeftijdVan", leeftijdV);
                comm.Parameters.AddWithValue("@LeeftijdTot", leeftijdT);
                comm.Parameters.AddWithValue("@Taal", taal);
                comm.ExecuteNonQuery();
            }
        }


    }






}

