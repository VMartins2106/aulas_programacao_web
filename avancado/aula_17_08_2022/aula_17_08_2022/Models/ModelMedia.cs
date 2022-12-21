using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Models
{
    public class ModelMedia
    {
        [DisplayName("Vendas de Janeiro")]
        public string Jan { get; set; }
        [DisplayName("Vendas de Fevereiro")]
        public string Fev { get; set; }
        [DisplayName("Vendas de Março")]
        public string Mar { get; set; }
        [DisplayName("Vendas de Abril")]
        public string Abr { get; set; }
    }
}