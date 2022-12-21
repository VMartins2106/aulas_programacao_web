using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Models
{
    public class ModelEscola
    {

        [DisplayName("Matriculados")]
        public string Matriculados { get; set; }
        [DisplayName("Formados")]
        public string Formados { get; set; }

    }
}