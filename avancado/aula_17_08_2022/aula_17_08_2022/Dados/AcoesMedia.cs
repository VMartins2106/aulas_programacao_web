using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Dados
{
    public class AcoesMedia
    {

        public double CalcularMedia(ModelMedia m)
        {

            return (double.Parse(m.Jan) + double.Parse(m.Fev) + double.Parse(m.Mar) + double.Parse(m.Abr)) / 4;

        }

        public double CalcularSoma(ModelMedia m)
        {

            return double.Parse(m.Jan) + double.Parse(m.Fev) + double.Parse(m.Mar) + double.Parse(m.Abr);

        }

    }
}