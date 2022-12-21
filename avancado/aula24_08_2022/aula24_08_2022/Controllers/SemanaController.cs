using aula24_08_2022.Dados;
using aula24_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula24_08_2022.Controllers
{
    public class SemanaController : Controller
    {
        // GET: Semana
        public ActionResult Index()
        {
            return View();
        }

        AcoesSemana acaoSemana = new AcoesSemana();

        [HttpPost]
        public ActionResult Index(SemanaModel mod)
        {

            ViewBag.Dia = acaoSemana.CalcularDia(mod);

            return View();
        }
    }
}