using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Walidacja.Models
{
    public class Pracownik
    {
        public int PracownikId { get; set; }
        public string Imie { get; set; }
        public int Wiek { get; set; }
        public string Email { get; set; }
        public string NumerTelefonu { get; set; }
        public string Pytanie { get; set; }

    }
}