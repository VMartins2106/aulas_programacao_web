using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace aula24_08_2022.Models
{
    public class PostoModel
    {

        [DisplayName("Tipo de combustivel" +
            " (escreva 'a'/'A' para álcool ou 'g'/'G' para gasolina")]
        public string a_g { get; set; }
        [DisplayName("Quantidade, em litros, de combustivel")]
        public string litros { get; set; }

    }
}