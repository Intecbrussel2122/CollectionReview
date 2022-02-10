using System;

namespace EindTestLibrary.Models
{
    public abstract class Product:IComparable<Product>
    {
        public int ProductNummer { get; set; }
        public string Merk { get; set; }
        public string Naam { get; set; }
        public int Volume { get; set; }
        public double Prijs { get; set; }

        public Product(int productNummer, string merk, string naam, int volume, double prijs)
        {
            ProductNummer = productNummer;
            Merk = merk;
            Naam = naam;
            Volume = volume;
            Prijs = prijs;
        }

        public int CompareTo(Product other)
        {
            return Merk.CompareTo(other.Merk);
        }

        public string GetProductCode()
        {
            return (Merk.PadRight(3).Substring(0, 3).ToUpper() +
                Naam.PadRight(3).Substring(0, 3).ToUpper() +
                Volume).Replace(" ","_");
        }

        public override string ToString()
        {
            return $"{ProductNummer} Merk:{Merk.PadRight(20)} Naam: {Naam.PadRight(30)} volume:{Volume.ToString().PadLeft(3)}ml Prijs: {Prijs.ToString("N2")} Code: {GetProductCode().PadRight(9)}";
        }
    }
}
