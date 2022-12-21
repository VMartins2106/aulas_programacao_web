using aula24_08_2022.Dados;
using aula24_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula24_08_2022.Controllers
{
    public class SomaController : Controller
    {
        // GET: Soma
        public ActionResult Index()
        {
            return View();
        }

        AcoesSoma acaoSoma = new AcoesSoma();

        [HttpPost]
        public ActionResult Index(SomaModel mod)
        {

            ViewBag.Soma = "A soma dos dois números maiores é de: " + acaoSoma.CalcularSoma(mod);

            return View();
        }

    }
}