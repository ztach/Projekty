using projekt3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult Parametry (int par1,int par2,string par3)
        {
            var text = (string.Format("par1: {0}, par2: {1}, par3: {2}", par1, par2, par3));
            return View();
        }
            
        public ActionResult Parametry2 (Person osoba)
        {
            //Response.Write(string.Format("Jesteś {0} {1} lat: {2}", osoba.Imie, osoba.Nazwisko, osoba.Age));
            //var text = (string.Format("Jesteś {0} {1} lat: {2}", osoba.Imie, osoba.Nazwisko, osoba.Age));
            return Content(string.Format("Jesteś {0} {1} lat: {2}", osoba.Imie, osoba.Nazwisko, osoba.Age));

        }
}
}