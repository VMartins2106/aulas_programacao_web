using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Dados
{
    public class AcoesRetangulo
    {

        public double CalcularArea(ModelRetangulo m)
        {

            return (double.Parse(m.Base) * double.Parse(m.Altura));

        }

    }
}