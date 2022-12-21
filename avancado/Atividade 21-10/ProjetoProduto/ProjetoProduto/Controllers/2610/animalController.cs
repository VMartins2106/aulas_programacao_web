using ProjetoProduto.Acoes._2610;
using ProjetoProduto.Models._2610;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoProduto.Controllers._2610
{
    public class animalController : Controller
    {
        acoesVETAnimal acCli = new acoesVETAnimal();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ModelVETAnimal m, HttpPostedFileBase file)
        {
            string arquivo = Path.GetFileName(file.FileName);
            string file2 = "/Imagens/" + Path.GetFileName(file.FileName);
            string _path = Path.Combine(Server.MapPath("~/Imagens"), arquivo);
            file.SaveAs(_path);
            m.fotoAnimal = file2;
            acCli.inserirAnimal(m);
            ViewBag.msg = "Cadastro efetuado com sucesso";
            return View();
        }

        public ActionResult ListarVETAnimal()
        {
            return View(acCli.GetAnimal());
        }

        public ActionResult excluirVETAnimal(int id)
        {
            acCli.DeleteAnimal(id);
            return RedirectToAction("ListarVETAnimal");
        }

        public ActionResult editarVETAnimal(string id)
        {
            return View(acCli.GetAnimal().Find(model => model.codAnimal == id));
        }

        [HttpPost]
        public ActionResult editarVETAnimal(int id, ModelVETAnimal cm)
        {
            cm.codAnimal = id.ToString();
            acCli.atualizaAnimal(cm);
            ViewBag.msg = "Cadastro atualizado com sucesso";
            return View();
        }
    }
}