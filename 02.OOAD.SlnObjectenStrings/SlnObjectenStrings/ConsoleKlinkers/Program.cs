using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkers
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string invoer = Console.ReadLine();


            char[] klinkers = new char[] { 'a', 'e', 'i', 'o', 'u','y' };



            int aantalKlinkers = invoer.Count(klinker => klinkers.Contains(klinker));

            klinkers = invoer.ToCharArray();

            Console.WriteLine("de tekst bevat {0} klinker(s)", aantalKlinkers.ToString());

           
            
            Console.WriteLine("In geheimeschrift ");

            foreach (char klinker in klinkers)
            {

                int geheimeCode = Convert.ToInt32(klinker);
                char ascii = Convert.ToChar(Convert.ToInt32(geheimeCode + 2)); 
                Console.Write(ascii );
            }

            Console.WriteLine();

            int aantalTekens = 0;
            int aantalSpaties = 0;
            int aantalTekensZonderSpaties = 0;

            for (int i = 0; i < invoer.Length; i++)
            {

                if (invoer.Substring(i,1) == " ")
                {
                    aantalSpaties++;
                }
                
                aantalTekens++;
            }

            aantalTekensZonderSpaties = aantalTekens - aantalSpaties;

            Console.WriteLine("De tekst bevat {0} tekens met spaties en {1} zonder spatie(s)", aantalTekens, aantalTekensZonderSpaties);
            Console.WriteLine("De tekst bevat {0} spatie(s)", aantalSpaties);
          

            Console.ReadLine();




        }


    }
}
