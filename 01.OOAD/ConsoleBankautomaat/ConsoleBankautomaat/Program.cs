using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankautomaat");

            Console.WriteLine("====================");

            Console.WriteLine();
            int saldo = 500, pinCode = 1234, invoerPinCode, aantalPogingen = 4;
            string invoer;


            do
            {
                Console.Write("Geef uw pincode: ");
                invoerPinCode = Convert.ToInt32(Console.ReadLine());
                aantalPogingen--;


                if (pinCode != invoerPinCode)
                {
                    Console.WriteLine("Foute Pincode, u hebt nog {0} pogingen", aantalPogingen);

                    if (aantalPogingen == 1)
                    {
                        Console.WriteLine("OPGELET er blijf maar EEN poging over anders zal uw kaart geblokkeert worden en uw programma zal automatisch uitgelogd worden.");

                    }
                    else if (aantalPogingen == 0)
                    {
                        Environment.Exit(0);
                    }

                }
                else
                {
                    Console.WriteLine("U bent ingelogd.");

                }
            }
            while (aantalPogingen != 0);


            do
            {
                Console.WriteLine("a. afhaling");
                Console.WriteLine("b. storting");
                Console.WriteLine("c. stoppen");
                Console.Write("je keuze: ");
                invoer = Console.ReadLine();

                if (invoer.ToLower() == "a")
                {


                    Console.Write("welk bedrag wil je afhalen: ");
                    int afhaling = Convert.ToInt32(Console.ReadLine());



                    if (saldo < afhaling)
                    {
                        Console.WriteLine("Uw afhaling is niet geaccepteerd omdat u maar {0} euro hebt ", saldo.ToString());
                    }
                    else if (saldo == afhaling)
                    {
                        saldo = saldo - afhaling;
                        Console.WriteLine("afhaling ok - het nieuwe saldo is {0} euro", saldo.ToString());
                    }
                    else
                    {
                        saldo = saldo - afhaling;
                        Console.WriteLine("afhaling ok - het nieuwe saldo is {0} euro ", saldo.ToString());
                    }
                }
                else if (invoer.ToLower() == "b")
                {
                    Console.Write("welk bedrag wil je storten: ");
                    int storting = Convert.ToInt32(Console.ReadLine());
                    saldo = saldo + storting;
                    Console.WriteLine("storting ok - het nieuwe saldo is {0} euro ", saldo.ToString());
                }
                else if (invoer.ToLower() == "c")
                {
                    Console.WriteLine("Bedankt en tot ziens.");
                }
                else
                {
                    Console.WriteLine("ongeldinge keuze");
                }
            } while (invoer.ToLower() != "c");



            Console.ReadLine();
        }
    }
}
