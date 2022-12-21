using ProjetoProduto.Acoes._2610;
using ProjetoProduto.Models._2610;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoProduto.Controllers._2610
{
    public class veterinarioController : Controller
    {
        acoesVETVet acCli = new acoesVETVet();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ModelVETVet m)
        {
            acCli.inserirVet(m);
            ViewBag.msg = "Cadastro efetuado com sucesso";
            return View();
        }

        public ActionResult ListarVETVet()
        {
            return View(acCli.GetVet());
        }

        public ActionResult excluirVETVet(int id)
        {
            acCli.DeleteVet(id);
            return RedirectToAction("ListarVETVet");
        }

        public ActionResult editarVETVet(string id)
        {
            return View(acCli.GetVet().Find(model => model.codVet == id));
        }

        [HttpPost]
        public ActionResult editarVETVet(int id, ModelVETVet cm)
        {
            cm.codVet = id.ToString();
            acCli.atualizaVet(cm);
            ViewBag.msg = "Cadastro atualizado com sucesso";
            return View();
        }
    }
}