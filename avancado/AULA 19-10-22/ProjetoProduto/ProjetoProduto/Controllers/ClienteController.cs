using ProjetoProduto.Acoes;
using ProjetoProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoProduto.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente

        acoesCliente acCli = new acoesCliente();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadCliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadCliente(ModelCliente cm)
        {
            if (cm.senha == cm.confSenha)
            {
                acCli.inserirCliente(cm);
                ViewBag.msg = "Cadastro efetuado com sucesso";
            }
            else
            {
                ViewBag.msg = "Senhas não conferem";
            }
            return View();
        }

        public ActionResult ListarCliente()
        {
            return View(acCli.GetCliente());
        }

        public ActionResult excluirCliente(int id)
        {
            acCli.DeleteCliente(id);
            return RedirectToAction("ListarCliente");
        }

        public ActionResult editarCliente(string id)
        {
            return View(acCli.GetCliente().Find(model => model.codCli == id));
        }

        [HttpPost]
        public ActionResult editarCliente(int id, ModelCliente cm)
        {
            cm.codCli = id.ToString();
            acCli.atualizaCliente(cm);
            return View();
        }

    }
}