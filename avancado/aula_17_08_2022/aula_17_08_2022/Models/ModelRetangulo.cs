using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Models
{
    public class ModelRetangulo
    {

        [DisplayName("Base")]
        public string Base { get; set; }
        [DisplayName("Altura")]
        public string Altura { get; set; }

    }
}