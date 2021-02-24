using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKarakter
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Geef een kleine letter: ");
            char invoer = Convert.ToChar(Console.ReadLine());

            int hoofdLetter = Convert.ToInt32(invoer) - 32;
            int vorigeLetter = Convert.ToInt32(invoer) - 1;
            int volgendeLetter = Convert.ToInt32(invoer) + 1;


            Console.WriteLine("het nummer is: {0}", Convert.ToInt32(invoer));
            Console.WriteLine("het hoofdletter is: {0}",Convert.ToChar(hoofdLetter));
            Console.WriteLine("het vorige letter is: {0}", Convert.ToChar(vorigeLetter));
            Console.WriteLine("het volgende letter is: {0}", Convert.ToChar(volgendeLetter));


            Console.ReadLine();

        }
    }
}
