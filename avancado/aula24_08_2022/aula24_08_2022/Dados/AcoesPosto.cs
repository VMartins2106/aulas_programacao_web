using aula24_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula24_08_2022.Dados
{
    public class AcoesPosto
    {

        double valor;

        public double CalcularPosto(PostoModel m)
        {

            if (m.a_g == "a" || m.a_g == "A")
            {

                if(double.Parse(m.litros) <= 25)
                {

                    valor = (double.Parse(m.litros) * (1.90 * 0.98));

                }
                else if (double.Parse(m.litros) > 25)
                {

                    valor = (double.Parse(m.litros) * (1.90 * 0.96));

                }

            }
            else if (m.a_g == "g" || m.a_g == "G")
            {

                if (double.Parse(m.litros) <= 25)
                {

                    valor = (double.Parse(m.litros) * (2.70 * 0.97));

                }
                else if (double.Parse(m.litros) > 25)
                {

                    valor = (double.Parse(m.litros) * (2.70 * 0.95));

                }

            }

            return valor;

        }
    }
}