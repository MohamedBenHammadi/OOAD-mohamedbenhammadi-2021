using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLibrary
{
    public class Auteur
    {
        static string connString = ConfigurationManager.AppSettings["connString"];

        public int Id { get; set; }
        public string Voornaam { get; set; }

        public string Achternaam { get; set; }



        public Auteur()
        {

        }


        public Auteur(int id, string vrmn, string achter)
        {
            Id = id;
            Voornaam = vrmn;
            Achternaam = achter;
        }


    }
}
