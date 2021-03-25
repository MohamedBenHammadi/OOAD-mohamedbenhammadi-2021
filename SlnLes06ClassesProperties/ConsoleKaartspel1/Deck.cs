using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKaartspel1
{
    class Deck
    {
       

        public List<Kaart> Kaarten { get; set; } = new List<Kaart>();



        //constructor


        public Deck()
        {


            for (int i = 0; i < 14; i++)
            {
                Kaart C = new Kaart(i, 'C');
                Kaart S = new Kaart(i, 'S');
                Kaart H = new Kaart(i, 'H');
                Kaart D = new Kaart(i, 'D');
                Kaarten.Add(C);
                Kaarten.Add(S);
                Kaarten.Add(H);
                Kaarten.Add(D);
            }


        }


        //bron: https://www.codegrepper.com/code-examples/csharp/c%23+randomize+a+list
        public void Schudden()
        {
            Random rnd = new Random();
            int n = Kaarten.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Kaart value = Kaarten[k];
                Kaarten[k] = Kaarten[n];
                Kaarten[n] = value;
            }
        }



        public Kaart NeemKaart()
        {
            Random r = new Random();
            int kaart = r.Next(0,Kaarten.Count);
            Kaarten.RemoveAt(kaart);
            Kaart neemKaart = Kaarten[kaart];
            return neemKaart;

        }




    }
}
