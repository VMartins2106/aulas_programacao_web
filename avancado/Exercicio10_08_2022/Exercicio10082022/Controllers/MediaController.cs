using Exercicio10082022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio10082022.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ModelMedia mod)
        {
            double soma, media;
            soma = double.Parse(mod.N1) + double.Parse(mod.N2) + double.Parse(mod.N3) + double.Parse(mod.N4);
            media = soma / 4;
            if (media >= 5)
            {
                ViewBag.Res = "Aluno aprovado";
            }
            else if (media >= 3)
            {
                ViewBag.Res = "Aluno em recuperação";
            }
            else
            {
                ViewBag.Res = "Aluno reprovado";
            }
            ViewBag.Soma = "A soma é: " + soma;
            ViewBag.Media = "A média é: " + media;
            return View();
        }
    }
}