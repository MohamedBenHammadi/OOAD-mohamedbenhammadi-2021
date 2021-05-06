using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKassaTicket
{
    public enum Betaalwijze { cash, visa, bancontact }
    class Ticket
    {

        private decimal _prijs = 0;

        public List<Product> Producten { get; set; } = new List<Product>();
        public string Voornaam { get; set; }
        public Betaalwijze Betaling { get; set; }

        public decimal TotaalPrijs
        {
            get
            {

                for (int i = 0; i < Producten.Count(); i++)
                {
                    _prijs += Producten[i].Eenheidsprijs;
                }

                return _prijs;
            }
        }

        //constructor

        public Ticket(string naamKassier, Betaalwijze typeBetaling)
        {
            Voornaam = naamKassier;
            Betaling = typeBetaling;

        }

        public void DrukTicket()
        {
            Console.WriteLine("KASSATICKET");
            Console.WriteLine("===========");
            Console.WriteLine($"uw kassier: {Voornaam}");
            Console.WriteLine();

            const double VISA_KOSTEN = 0.12;
            for (int i = 0; i < Producten.Count(); i++)
            {
                Console.WriteLine($"{Producten[i].Code} {Producten[i].Naam}: {Producten[i].Eenheidsprijs} ");
            }
            Console.WriteLine("-----------");

            if (Betaling == Betaalwijze.visa)
            {
                Console.WriteLine($"visa kosten: { VISA_KOSTEN}");
                Console.WriteLine($"Totaal: { TotaalPrijs + Convert.ToDecimal(VISA_KOSTEN)} ");
            }
            else
            {
                Console.WriteLine($"Betaalwijze: {Betaling} ");
                Console.WriteLine($"Totaal: { TotaalPrijs} ");
            }

        }






    }
}
