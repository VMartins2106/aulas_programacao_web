using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace aula24_08_2022.Models
{
    public class ExameModel
    {

        [DisplayName("Exame 1")]
        public string E1 { get; set; }
        [DisplayName("Exame 2")]
        public string E2 { get; set; }
        [DisplayName("Exame 3")]
        public string E3 { get; set; }
        [DisplayName("Exame 4")]
        public string E4 { get; set; }
        [DisplayName("Exame 5")]
        public string E5 { get; set; }

    }
}