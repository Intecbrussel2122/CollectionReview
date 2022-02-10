using EindTestLibrary.Enumerations;
using EindTestLibrary.Models;

namespace CollectionReview.Models
{
    public static class Factory
    {
        public static AfterShave CreateAfterShave(string merk, string naam, int volume, double prijs, Soort soort)
        {
            return new AfterShave(Bestelling.ProductNummer, merk,naam,volume,prijs,soort);
        }

        public static Parfum CreateParfum(string merk, string naam, int volume, double prijs)
        {
            return new Parfum(Bestelling.ProductNummer, merk, naam, volume, prijs);
        }

        public static Deodorant CreateDeodorant(string merk, string naam, int volume, double prijs, DeoType deoType)
        {
            return new Deodorant(Bestelling.ProductNummer, merk, naam, volume, prijs, deoType);
        }

        public static Bestelling CreateBestelling()
        {
            return new Bestelling();
        }
    }
}
