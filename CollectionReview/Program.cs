using CollectionReview.Models;
using EindTestLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EindTestLibrary.Enumerations;
using System.IO;

namespace CollectionReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WindowWidth = Console.LargestWindowWidth;

            Bestelling bestelling = Factory.CreateBestelling();
            bestelling.VoegProductToe(Factory.CreateParfum("Dolce & Gabbana", "Light Blue", 100, 66.72));
            bestelling.VoegProductToe(Factory.CreateAfterShave("BVLGARI", "BLV", 75, 61.52,Soort.VAPO));
            bestelling.VoegProductToe(Factory.CreateDeodorant("Cacharel", "Anais", 50, 24.50, DeoType.STICK));

            SaveBestelling(bestelling, Directory.GetCurrentDirectory() + "\\Bestelling.txt");

            bestelling.SorteerOpMerk();
            bestelling.ToonLijst();
            Console.WriteLine("Gorgio Armani");
            bestelling.ToonPerMerk("armani");

            Console.WriteLine("Alle parfumes");
            bestelling.ToonParfums();
            Console.WriteLine($"Duurste product {bestelling.ZoekDuursteProduct()}");
            Console.WriteLine($"Totale Prijs {bestelling.TotalPrijs()}");
            Console.ReadKey();
        }
        private static void SaveBestelling(Bestelling bestelling, string filename)
        {
            try
            {
                WegSchrijven.WriteListToFile(bestelling.Bestellingen, filename);
                File.AppendAllText(filename, "Totale prijs: " + bestelling.TotalPrijs().ToString("C2"));
            }
            catch (Exception err)
            {
                Console.WriteLine("Er is een fout opgetreden bij het opslaan van de bestelling: " + err.Message);
                LogError(err);
            }
        }

        private static void LogError(Exception exception)
        {
            using (FileStream fs = new FileStream("errors.log", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("\nFout bij opslaan bestelling");
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine(exception.ToString());
                }
            }
        }
    }
}
