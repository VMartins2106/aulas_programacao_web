using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProduto.Models._2610
{
    public class ModelVETAtendimento
    {
        public string codAtendimento { get; set; }
        public string dataAtendimento { get; set; }
        public string horaAtendimento { get; set; }
        public string fkcodAnimal { get; set; }
        public string fkcodVeterinario { get; set; }
        public string diagnostico { get; set; }
    }
}