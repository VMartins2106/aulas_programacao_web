using aula_17_08_2022.Dados;
using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula_17_08_2022.Controllers
{
    public class EscolaController : Controller
    {
        // GET: Escola
        public ActionResult Index()
        {
            return View();
        }

        AcoesEscola ae = new AcoesEscola();

        [HttpPost]
        public ActionResult Index(ModelEscola mod)
        {
            ViewBag.Evasao = "A evasão dos alunos é de: " + ae.CalcularEvasao(mod) + "%";

            if (ae.CalcularEvasao(mod) <= 10)
            {
                ViewBag.Texto = "Baixa evasão";
            }
            else if (ae.CalcularEvasao(mod) > 10 && ae.CalcularEvasao(mod) <= 15)
            {
                ViewBag.Texto = "Evasão média";
            }
            else if (ae.CalcularEvasao(mod) > 15 && ae.CalcularEvasao(mod) <= 25)
            {
                ViewBag.Texto = "Evasão alta";
            }
            else if (ae.CalcularEvasao(mod) > 25)
            {
                ViewBag.Texto = "Evasão muito alta";
            }

            return View();
        }
    }
}