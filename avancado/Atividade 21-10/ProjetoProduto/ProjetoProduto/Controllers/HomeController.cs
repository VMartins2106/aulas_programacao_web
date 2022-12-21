using ProjetoProduto.Acoes;
using ProjetoProduto.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoProduto.Controllers
{
    public class HomeController : Controller
    {
        acoesProduto acProd = new acoesProduto();
        public ActionResult ListarProdutos()
        {
            return View(acProd.GetProd());
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Indexx()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Indexx(ModelProduto cmProd, HttpPostedFileBase file)
        {
            string arquivo = Path.GetFileName(file.FileName);
            string file2 = "/Imagens/" + Path.GetFileName(file.FileName);
            string _path = Path.Combine(Server.MapPath("~/Imagens"), arquivo);
            file.SaveAs(_path);
            cmProd.FotoProd = file2;
            acProd.inserirProduto(cmProd);
            ViewBag.msg = "Cadastro realizado";
            return View();
        }

    }
}