using aula24_08_2022.Dados;
using aula24_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula24_08_2022.Controllers
{
    public class PostoController : Controller
    {
        // GET: Posto
        public ActionResult Index()
        {
            return View();
        }

        AcoesPosto acaoPosto = new AcoesPosto();

        [HttpPost]
        public ActionResult Index(PostoModel mod)
        {

            ViewBag.Posto = "Valor de: R$ " + acaoPosto.CalcularPosto(mod);

            return View();
        }
    }
}