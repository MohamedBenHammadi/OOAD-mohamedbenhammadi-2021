using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLibrary
{
    public class Boek
    {
        static string connString = ConfigurationManager.AppSettings["connString"];


        public int Id { get; set; }

        public string Isbn { get; set; }

        public int Aantalpaginas  { get; set; }

        public int Auteurd { get; set; }


      public Boek(int id, string isbn, int aantalpaginas)
        {
            Id = id;
            Isbn = isbn;
            Aantalpaginas = aantalpaginas;
        }


        public Boek(int id, string isbn, int aantalpaginas, int auteurId) : this(id,isbn,aantalpaginas)
        {
            Auteurd = auteurId;
        }


    }
}
