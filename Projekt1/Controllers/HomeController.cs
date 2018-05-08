using Projekt1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Omnie()
        {
            ViewBag.Message = "info o mnie i mojej stronie.";
            List<Kontakt> kontakt = new List<Kontakt>()
            {
                new Kontakt("Staszek","Olejnik","Kraków","Tuchowska"),
                new Kontakt("Irena","Wycisk","Warszawa","Pijana 12")
            };

            ViewBag.Kontakty = kontakt;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}