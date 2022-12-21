using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProduto.Models._2610
{
    public class ModelVETAnimal
    {
        public string codAnimal { get; set; }
        public string nomeAnimal { get; set; }
        public string fotoAnimal { get; set; }
        public string fkcodtipoanimal { get; set; }
        public string fkcodcliente { get; set; }
    }
}