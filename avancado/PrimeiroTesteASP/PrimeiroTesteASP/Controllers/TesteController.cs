using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroTesteASP.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ex1()
        {
            return View();
        }

        double n1, n2, total, peso, altura, imc;
        public ActionResult ResEx1(FormCollection frm)
        {
            n1 = double.Parse(frm["txtn1"]);
            n2 = double.Parse(frm["txtn2"]);
            total = n1 + n2;
            ViewBag.Total = total;
            return View();
        }

        public ActionResult Ex2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ex2(FormCollection frm)
        {
            peso = double.Parse(frm["peso"]);
            altura = double.Parse(frm["altura"]);
            imc = peso / altura * altura;
            ViewBag.ResIMC = imc;

            if (imc < 18.5)
            {
                ViewBag.Avaliacao = "Abaixo do peso";
            }
            else if (imc > 18.5 && imc <= 25)
            {
                ViewBag.Avaliacao = "Peso normal";
            }
            else if (imc > 25 && imc <= 30)
            {
                ViewBag.Avaliacao = "Sobrepeso";
            }
            else if (imc > 30 && imc <= 35)
            {
                ViewBag.Avaliacao = "Obesidade 1";
            }
            else if (imc > 35 && imc <= 40)
            {
                ViewBag.Avaliacao = "Obesidade 2";
            }
            else if (imc > 40 && imc <= 45)
            {
                ViewBag.Avaliacao = "Obesidade 3";
            }
            return View();
        }

        public ActionResult Ex3()
        {
            return View();
        }
    }
}