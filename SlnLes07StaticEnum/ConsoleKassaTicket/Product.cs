using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKassaTicket
{
    class Product
    {
        private string _code;
        private const int AANTAL_TEKENS = 6;
        public string Naam { get; set; }
        public decimal Eenheidsprijs { get; set; }

        public string Code
        {
            get { return _code; }
            set
            {
                if (value.Length == AANTAL_TEKENS && value.Substring(0, 1) == "P")
                {
                    _code = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                     $"Uw code moet 6 karakters lang zijn en moet een P in het begin bevatten ");
                }

            }
        }


        public Product(string code, string naam, decimal prijs)
        {
            Code = code;
            Naam = naam;
            Eenheidsprijs = prijs;
        }



        //methoden

        public bool ValideerCode(string code)
        {
            return code.Length == AANTAL_TEKENS && code.Substring(0, 1) == "P";
        }

        public override string ToString()
        {
            return $"{Code} {Naam} {Eenheidsprijs} ";
        }


    }
}
