using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKaartspel1
{
    class Kaart
    {
        private int _nummer;
        private char _kleur;

        public int Nummer
        {
            get { return _nummer; }
            set
            {
                _nummer = value > 0 || value < 14 ? _nummer = value :
                throw new Exception("Het waarde moet tussen 1 en 13 zijn.");
            }
        }
        public char Kleur
        {
            get { return _kleur; }
            set
            {
                if (value == 'C' || value == 'S' || value == 'H' || value == 'D')
                {
                    _kleur = value;
                  
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                     $"U moet een geldige kleur kiezen (C,S,H of D");
                }
               
            }
        }

        //constructor
        public Kaart(int nummer, char kleur)
        {
            _nummer = nummer;
            _kleur = kleur;
            
        }
    }
}
