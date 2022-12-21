using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula10082022.Controllers
{
    public class RevisaoController : Controller
    {
        // GET: Revisao
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(FormCollection frm)
        {
            double n1, n2, n3, n4, soma, media;
            n1 = double.Parse(frm["txtn1"]);
            n2 = double.Parse(frm["txtn2"]);
            n3 = double.Parse(frm["txtn3"]);
            n4 = double.Parse(frm["txtn4"]);
            soma = n1 + n2 + n3 + n4;
            media = soma / 4;
            ViewBag.Soma = "A soma é: " + soma;
            ViewBag.Media = "A média é: " + media;

            if (media >= 5)
            {
                ViewBag.Res = "O aluno foi aprovado";
            }
            else if(media>=3)
            {
                ViewBag.Res = "O aluno está de recuperação";
            }
            else
            {
                ViewBag.Res = "O aluno foi reprovado";
            }

            return View();
        }
    }
}