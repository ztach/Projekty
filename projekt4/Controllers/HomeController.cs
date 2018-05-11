using projekt4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Person> listPerson = new List<Person>() {
                new Person() {Imie="Staszek",Nazwisko="Fiks",Age=32,Email="ztach@poczta.onet.pl"},
                new Person() {Imie="Janek",Nazwisko="Piksowy",Age=28,Email="Janek.Piksowy@onet.pl"},
                new Person() {Imie="Magdalena",Nazwisko="Optaszkowa",Age=28,Email="Madzia.Padzia@onet.pl"}
            };

            ViewBag.ListaPersons = listPerson;

            return View(listPerson);
        }

         // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        
        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Omnie()
        {
            Omnie toja = new Omnie();

            return View(toja);
        }
 
    }
}
