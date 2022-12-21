using aula_17_08_2022.Dados;
using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula_17_08_2022.Controllers
{
    public class TrapezioController : Controller
    {
        // GET: Trapezio
        public ActionResult Index()
        {
            return View();
        }

        AcoesTrapezio at = new AcoesTrapezio();

        [HttpPost]
        public ActionResult Index(ModelTrapezio mod)
        {
            ViewBag.Area = "A área do trapézio é: " + at.CalcularArea(mod);

            return View();
        }
    }
}