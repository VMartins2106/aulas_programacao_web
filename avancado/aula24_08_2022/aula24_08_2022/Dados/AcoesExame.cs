using aula24_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula24_08_2022.Dados
{
    public class AcoesExame
    {

        String res;

        public String CalcularExame(ExameModel m)
        {

            double media = (double.Parse(m.E1) + double.Parse(m.E2) + double.Parse(m.E3)
                + double.Parse(m.E4) + double.Parse(m.E5)) / 5;

            if (double.Parse(m.E1) >= media && double.Parse(m.E2) >= 70 && double.Parse(m.E3) >= 70
                 && double.Parse(m.E4) >= 70 && double.Parse(m.E5) >= 70)
            {
                res = "Você passou em todas !";
            }
            else if (double.Parse(m.E1) >= media && double.Parse(m.E2) >= 70 && double.Parse(m.E3) <= 70
                 && double.Parse(m.E4) >= 70 && double.Parse(m.E5) <= 70)
            {
                res = "Você passou nos exames I, II, IV, mas não em III e V !";
            }
            else if (double.Parse(m.E1) >= media && double.Parse(m.E2) >= 70 && double.Parse(m.E3) >= 70
                 && double.Parse(m.E4) >= 70 && double.Parse(m.E5) <= 70)
            {
                res = "Você passou nos exames I, II, III, IV, mas não em V !";
            }
            else
            {
                res = "Você foi reprovado !";
            }
            
            return res;
        }

        public double CalcularMedia(ExameModel modd)
        {

            double media = (double.Parse(modd.E1) + double.Parse(modd.E2) + double.Parse(modd.E3)
                + double.Parse(modd.E4) + double.Parse(modd.E5)) / 5;

            return media;

        }


    }
}