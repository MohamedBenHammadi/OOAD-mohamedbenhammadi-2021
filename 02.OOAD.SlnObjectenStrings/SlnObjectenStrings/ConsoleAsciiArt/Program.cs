using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("AsciiArt" + Environment.NewLine);

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if ((j+i) % 2 == 0)
                    {
                        Console.Write(@"█");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
