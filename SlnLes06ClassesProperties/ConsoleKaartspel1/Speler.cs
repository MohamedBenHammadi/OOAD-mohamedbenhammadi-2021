using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKaartspel1
{
    class Speler
    {
        //propreties
        public List<Kaart> Kaarten { get; set; } = new List<Kaart>();
        public string Naam { get; }
        public bool HeeftNogKaarten { get; set; }
    
        //constructor

        //eentje met naam
        public Speler(string naam)
        {
            Naam = naam;
        }

        //eentje met naam en lijskaarten
        public Speler(string naam, List<Kaart> kaarten)
        {
            Naam = naam;
            Kaarten = kaarten;
        }

        public Kaart LegKaart()
        {
            Random random = new Random();
            int willekeurigeKaart = random.Next(0,Kaarten.Count);
            Kaart legKaart = Kaarten[willekeurigeKaart];
            HeeftNogKaarten = Kaarten.Count > 1 ? false : true;
            return legKaart;
        }


    }
}
