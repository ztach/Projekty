using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home ActionResult 
        public string Index()
        {
            string wynik = "";
            foreach (string routkey in RouteData.Values.Keys)
            {
                wynik += "klucz: " + routkey + " wartość: " + RouteData.Values[routkey].ToString();
                wynik += "<br />";
            }

            return wynik;
           // return "witaj Stachu";// View();
        }
    }
}