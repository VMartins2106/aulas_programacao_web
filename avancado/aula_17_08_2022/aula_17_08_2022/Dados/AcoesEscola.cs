using aula_17_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula_17_08_2022.Dados
{
    public class AcoesEscola
    {

        public double CalcularEvasao(ModelEscola m)
        {
            double restante = (double.Parse(m.Matriculados) - double.Parse(m.Formados));
            double evasao = (restante / double.Parse(m.Matriculados)) * 100;
            return evasao;
        }

    }
}