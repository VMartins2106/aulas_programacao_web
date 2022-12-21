using ProjetoProduto.Acoes._2610;
using ProjetoProduto.Models._2610;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoProduto.Controllers._2610
{
    public class ClienteVETController : Controller
    {

        acoesVETCliente acCli = new acoesVETCliente();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ModelVETCliente m)
        {
            acCli.inserirCliente(m);
            ViewBag.msg = "Cadastro efetuado com sucesso";
            return View();
        }

        public ActionResult ListarVETCliente()
        {
            return View(acCli.GetCliente());
        }

        public ActionResult excluirVETCliente(int id)
        {
            acCli.DeleteCliente(id);
            return RedirectToAction("ListarVETCliente");
        }

        public ActionResult editarVETCliente(string id)
        {
            return View(acCli.GetCliente().Find(model => model.codCliente == id));
        }

        [HttpPost]
        public ActionResult editarVETCliente(int id, ModelVETCliente cm)
        {
            cm.codCliente = id.ToString();
            acCli.atualizaCliente(cm);
            return View();
        }

    }
}