using EindTestLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindTestLibrary.Models
{
    public class Deodorant:Product
    {
        public DeoType DeoType { get; set; }

        public Deodorant(int productNummer, string merk, string naam, int volume, double prijs, DeoType deoType) : base(productNummer, merk, naam, volume, prijs)
        {
            DeoType = deoType;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t{DeoType}";
        }
    }
}
