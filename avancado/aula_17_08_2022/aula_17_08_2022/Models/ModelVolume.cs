using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Models
{
    public class ModelVolume
    {

        [DisplayName("Comprimento")]
        public string Comprimento { get; set; }
        [DisplayName("Largura")]
        public string Largura { get; set; }
        [DisplayName("Altura")]
        public string Altura { get; set; }

    }
}