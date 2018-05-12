using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt4.Models
{
    public class Wspolnoty
    {
        public string Wspolnta;
        public string Index;
        public int sfkPrzedsiebiorstwoId;

        public Wspolnoty(string w,string ind , int id)
        {
            this.Wspolnta = w;
            this.Index = ind;
            this.sfkPrzedsiebiorstwoId = id;
        }

    }
}