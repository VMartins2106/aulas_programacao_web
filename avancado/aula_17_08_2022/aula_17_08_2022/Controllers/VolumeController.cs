using aula_17_08_2022.Dados;
using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula_17_08_2022.Controllers
{
    public class VolumeController : Controller
    {
        // GET: Volume
        public ActionResult Index()
        {
            return View();
        }

        AcoesVolume av = new AcoesVolume();

        [HttpPost]
        public ActionResult Index(ModelVolume mod)
        {
            ViewBag.Volume = "O volume da caixa é de: " + av.CalcularVolume(mod) + " metros cúbicos";

            return View();
        }
    }
}