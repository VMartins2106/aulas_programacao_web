using ProjetoProduto.Acoes._2610;
using ProjetoProduto.Models._2610;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoProduto.Controllers._2610
{
    public class AtendimentoController : Controller
    {
        // GET: Atendimento
        public ActionResult Index()
        {
            return View();
        }

        acoesAtend acAtend = new acoesAtend();

        [HttpPost]
        public ActionResult Index(ModelVETAtendimento m)
        {
            acAtend.inserirAtendimento(m);
            ViewBag.msg = "Cadastro efetuado com sucesso";
            return View();
        }

        public ActionResult Listar()
        {
            return View(acAtend.GetAtendimento());
        }

        public ActionResult excluirVETAtend(int id)
        {
            acAtend.DeleteAtendimento(id);
            return RedirectToAction("ListarVETAtend");
        }

        public ActionResult editarVETAtend(string id)
        {
            return View(acAtend.GetAtendimento().Find(model => model.codAtendimento == id));
        }

        [HttpPost]
        public ActionResult editarVETAtend(int id, ModelVETAtendimento cm)
        {
            cm.codAtendimento = id.ToString();
            acAtend.atualizaAtendimento(cm);
            ViewBag.msg = "Cadastro atualizado com sucesso";
            return View();
        }
    }
}