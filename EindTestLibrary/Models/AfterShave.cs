using EindTestLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindTestLibrary.Models
{
    public class AfterShave:Product
    {
        public Soort Soort { get; set; }

        public AfterShave(int productNummer, string merk, string naam, int volume, double prijs, Soort soort ):base(productNummer, merk, naam, volume, prijs)
        {
            Soort = soort;
        }
        public override string ToString()
        {
            return base.ToString() + $"\t{Soort}";
        }
    }
}
