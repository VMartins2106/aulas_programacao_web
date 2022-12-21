using aula_17_08_2022.Dados;
using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula_17_08_2022.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        public ActionResult Index()
        {
            return View();
        }

        AcoesMedia ac = new AcoesMedia();

        [HttpPost]
        public ActionResult Index(ModelMedia mod)
        {
            ViewBag.Soma = "A soma dos meses é: " + ac.CalcularSoma(mod);
            ViewBag.Media = "A média dos meses é: " + ac.CalcularMedia(mod);
            if (ac.CalcularMedia(mod) >= 500)
            {
                ViewBag.Res = "Meta Superada";
            }
            else if (ac.CalcularMedia(mod) >= 300)
            {
                ViewBag.Res = "Meta Atingida";
            }
            else
            {
                ViewBag.Res = "Meta não atingida";
            }

            return View();
        }
    }
}