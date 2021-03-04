using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleCsv
{
    class Program
    {
        static void Main(string[] args)
        {



            Random random = new Random();
            string[] namen = new string[] { "mohamed", "Morgen", "Sansone", "Mic" };
            string[] Soortspel = new string[] { "schaak", "dammen", "backgammon" };


            for (int i = 0; i <= 100; i++)
            {
                int keuzeSpeler = random.Next(0, namen.Length);
                int keuzeSpeler2 = random.Next(0, namen.Length);
                int keuzeSpel = random.Next(0, Soortspel.Length);


                string speler = namen[keuzeSpeler];
                string speler2 = namen[keuzeSpeler];
                string spel = Soortspel[keuzeSpel];

                string csvContent = "";

                csvContent = $"{i + 1};{speler};{ speler2};{spel};";

                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(folderPath, "wedstrijden.csv");

                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine(csvContent);
                }

                Console.WriteLine("csv generated");
                Console.ReadKey();


            }

        }
    }
}
