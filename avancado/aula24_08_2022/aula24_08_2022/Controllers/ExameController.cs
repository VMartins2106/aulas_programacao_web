using aula24_08_2022.Dados;
using aula24_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula24_08_2022.Controllers
{
    public class ExameController : Controller
    {
        // GET: Exame
        public ActionResult Index()
        {
            return View();
        }

        AcoesExame acaoExame = new AcoesExame();

        [HttpPost]
        public ActionResult Index(ExameModel mod)
        {

            ViewBag.Exame = acaoExame.CalcularExame(mod);

            ViewBag.Media = acaoExame.CalcularMedia(mod);
            return View();
        }
    }
}