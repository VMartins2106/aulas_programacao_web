using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Dados
{
    public class AcoesTrapezio
    {

        public double CalcularArea(ModelTrapezio m)
        {

            return ((double.Parse(m.Bmaior) + double.Parse(m.Bmenor)) * double.Parse(m.Altura) / 2);

        }

    }
}