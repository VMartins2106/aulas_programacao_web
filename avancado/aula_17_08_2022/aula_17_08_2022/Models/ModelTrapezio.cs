using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Models
{
    public class ModelTrapezio
    {

        [DisplayName("Base maior")]
        public string Bmaior { get; set; }
        [DisplayName("Base menor")]
        public string Bmenor { get; set; }
        [DisplayName("Altura")]
        public string Altura { get; set; }

    }
}