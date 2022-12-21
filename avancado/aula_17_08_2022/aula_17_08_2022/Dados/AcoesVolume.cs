using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Dados
{
    public class AcoesVolume
    {

        public double CalcularVolume(ModelVolume m)
        {
            double volume = (double.Parse(m.Comprimento) * double.Parse(m.Largura) * double.Parse(m.Altura));
            return volume;
        }

    }
}