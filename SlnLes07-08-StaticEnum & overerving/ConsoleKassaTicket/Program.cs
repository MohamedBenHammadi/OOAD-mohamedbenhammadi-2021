using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKassaTicket
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product("P12345", "kip", 10.25m);
            Product product2 = new Product("P67895", "vlees", 12.50m);
            Ticket ticket = new Ticket("momo", Betaalwijze.cash);
            ticket.Producten.Add(product1);
            ticket.Producten.Add(product2);


            ticket.DrukTicket();
            Console.ReadLine();

        }
    }
}
