using System.Globalization;

namespace SubiektGT.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Numer { get; set; }
        public string Kontrahent { get; set; }
        public decimal Wartosc { get; set; }
    }
}
