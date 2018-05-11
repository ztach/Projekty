using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace projekt2.Controllers
{
    [RoutePrefix("atrybutPrefix")]
    public class SklepController : Controller
    {
        [Route("atrybut/terenowy/{parametr}/trasa")]
        public string StronaSklepu(string parametr)
        {
            return "jesteś w sklepie";
        }

        [Route("{parametr:int}")]
        public string Test(string parametr)
        {
            return parametr;
        }


    }
}