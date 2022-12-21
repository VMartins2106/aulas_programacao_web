using ProjetoProduto.Acoes._2610;
using ProjetoProduto.Models._2610;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoProduto.Controllers._2610
{
    public class tipoAnimalController : Controller
    {
        acoesVETTipo acCli = new acoesVETTipo();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ModelVETTipo m)
        {
            acCli.inserirTipo(m);
            ViewBag.msg = "Cadastro efetuado com sucesso";
            return View();
        }

        public ActionResult ListarVETTipo()
        {
            return View(acCli.GetTipo());
        }

        public ActionResult excluirVETTipo(int id)
        {
            acCli.DeleteTipo(id);
            return RedirectToAction("ListarVETTipo");
        }

        public ActionResult editarVETTipo(string id)
        {
            return View(acCli.GetTipo().Find(model => model.codTipoAnimal == id));
        }

        [HttpPost]
        public ActionResult editarVETTipo(int id, ModelVETTipo cm)
        {
            cm.codTipoAnimal = id.ToString();
            acCli.atualizaTipo(cm);
            ViewBag.msg = "Cadastro atualizado com sucesso";
            return View();
        }

    }
}