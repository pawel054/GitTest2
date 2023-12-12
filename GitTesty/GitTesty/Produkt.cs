using System;
using System.Collections.Generic;
using System.Text;

namespace GitTesty
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public int Ilosc { get; set; }

        public Produkt(string nazwa, double cena, int ilosc)
        {
            Nazwa = nazwa;
            Cena = cena;
            Ilosc = ilosc;
        }

        public Produkt() { }
    }
}
