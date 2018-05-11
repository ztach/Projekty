using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt4.Models
{
    public class Omnie
    {
        private string _Imie = "Stanisław";
        private string _Nazwisko = "Olejnik";
        private string _Adres = "Kraków";
        private string _Email = "ztach@poczta.onet.pl";
        private string _Pesel = "58111552673";

        public string Imie {get {return _Imie; }}
        public string Nazwisko { get { return _Nazwisko; } }
        public string Adres { get { return _Adres; } }
        public string Email { get { return _Email; } }
        public string Pesel { get { return _Pesel; } }
    }
}