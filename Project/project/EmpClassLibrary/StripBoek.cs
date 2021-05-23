using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLibrary
{
    public class StripBoek
    {
        static string connString = ConfigurationManager.AppSettings["connString"];

        public int Itemid { get; set; }

        public string Volgnummer { get; set; }

        public int AuteurId { get; set; }


        public StripBoek(int id, string volgnmr)
        {
            Volgnummer = volgnmr;
            Itemid = id;
        }

        public StripBoek(int id, string volgnmr, int auteurid) : this(id, volgnmr)
        {
            AuteurId = auteurid;
        }
    }
}
