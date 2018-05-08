using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt1.Models
{
    public class Kontakt
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }

        public Kontakt(string sImie, string sNazwisko, string sMiasto, string sUlica)
        {
            Imie = sImie;
            Nazwisko = sNazwisko;
            Miasto = sMiasto;
            Ulica = sUlica;
        }

    }
}