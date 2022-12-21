using aula_17_08_2022.Dados;
using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula_17_08_2022.Controllers
{
    public class RetanguloController : Controller
    {
        // GET: Retangulo
        public ActionResult Index()
        {
            return View();
        }

        AcoesRetangulo ar = new AcoesRetangulo();

        [HttpPost]
        public ActionResult Index(ModelRetangulo mod)
        {
            ViewBag.AreaRetangulo = "A área do retângulo é: " + ar.CalcularArea(mod);

            return View();
        }
    }
}