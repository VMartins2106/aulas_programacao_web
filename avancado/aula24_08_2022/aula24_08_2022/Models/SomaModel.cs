using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace aula24_08_2022.Models
{
    public class SomaModel
    {

        [DisplayName("Primeiro número")]
        public string Pri { get; set; }
        [DisplayName("Segundo número")]
        public string Seg { get; set; }
        [DisplayName("Terceiro número")]
        public string Ter { get; set; }

    }
}