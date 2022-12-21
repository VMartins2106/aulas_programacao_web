using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Exercicio10082022.Models
{
    public class ModelMedia
    {
        [DisplayName("Primeiro número")]
        public String N1 { get; set; }
        [DisplayName("Segundo número")]
        public String N2 { get; set; }
        [DisplayName("Terceiro número")]
        public String N3 { get; set; }
        [DisplayName("Quarto número")]
        public String N4 { get; set; }

    }
}