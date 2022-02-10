using EindTestLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindTestLibrary.Models
{
    public class Bestelling : IBerekenbaar
    {
        public List<Product> Bestellingen { get; private set; } = new List<Product>();
        public static int ProductNummer { get; set; } = 1000;

        public void VoegProductToe(Product product)
        {
            Bestellingen.Add(product);
            ProductNummer++;
        }
        public void ToonParfums()
        {
            Console.WriteLine("Dit zijn Parfums");
            Console.WriteLine("");
            var results = Bestellingen.Where(x => x is Parfum).ToList();
            results.ForEach(x => Console.WriteLine(x));
        }
        public void SorteerOpMerk()
        {
            Bestellingen.Sort();
        }
        public void ToonLijst()
        {
            Console.WriteLine("Hier worden alle producten getoond");
            //foreach (var item in Bestellingen)
            //{
            //    Console.WriteLine(item);
            //}
            Bestellingen.ForEach(i => Console.WriteLine(i));
        }

        public void ToonPerMerk(string merk)
        {
            Console.WriteLine("Hier tonen wij per merk");
            var result = Bestellingen.Where(x => x.Merk.ToUpper().Contains(merk.ToUpper())).ToList();
            result.ForEach(i => Console.WriteLine());
        }

        public Product ZoekDuursteProduct()
        {
           return Bestellingen.OrderByDescending(x => x.Prijs).FirstOrDefault();
        }


        public double TotalPrijs()
        {
            return Bestellingen.Sum(x => x.Prijs);
        }
    }
}
