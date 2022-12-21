using aula24_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula24_08_2022.Dados
{
    public class AcoesSemana
    {

        String res;

        public String CalcularDia(SemanaModel m)
        {

            if (int.Parse(m.Dia) < 1 || int.Parse(m.Dia) > 7)
            {

                res = "Erro: digite um número entre 1 e 7";

            }
            else if(int.Parse(m.Dia) == 1)
            {

                res = "Seu dia caiu em um domingo !";

            }
            else if (int.Parse(m.Dia) == 2)
            {

                res = "Seu dia caiu em um segunda !";

            }
            else if (int.Parse(m.Dia) == 3)
            {

                res = "Seu dia caiu em um terça !";

            }
            else if (int.Parse(m.Dia) == 4)
            {

                res = "Seu dia caiu em um quarta !";

            }
            else if (int.Parse(m.Dia) == 5)
            {

                res = "Seu dia caiu em um quinta !";

            }
            else if (int.Parse(m.Dia) == 6)
            {

                res = "Seu dia caiu em um sexta !";

            }
            else if (int.Parse(m.Dia) == 7)
            {

                res = "Seu dia caiu em um sábado !";

            }

            return res;
        }

    }
}