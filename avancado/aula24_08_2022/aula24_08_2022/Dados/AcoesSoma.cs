using aula24_08_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula24_08_2022.Dados
{
    public class AcoesSoma
    {
        double soma = 0;

        public double CalcularSoma(SomaModel m)
        {

            //1 MAIOR
            if (double.Parse(m.Pri) > double.Parse(m.Seg) && double.Parse(m.Pri) > double.Parse(m.Ter))
            {

                // N1 + N2
                if(double.Parse(m.Seg) > double.Parse(m.Ter))
                {   
                    soma = double.Parse(m.Pri) + double.Parse(m.Seg);
                }

                //N1 + N3
                else if(double.Parse(m.Ter) > double.Parse(m.Seg))
                {
                    soma = double.Parse(m.Pri) + double.Parse(m.Ter);
                }
                //N2 = N3
                else if(double.Parse(m.Seg) == double.Parse(m.Ter))
                {
                    soma = double.Parse(m.Pri);
                }

            }
            //2 MAIOR
            else if (double.Parse(m.Seg) > double.Parse(m.Pri) && double.Parse(m.Seg) > double.Parse(m.Ter))
            {

                // N2 + N3
                if (double.Parse(m.Ter) > double.Parse(m.Pri))
                {
                    soma = double.Parse(m.Seg) + double.Parse(m.Ter);
                }
                // N2 + N1
                else if (double.Parse(m.Pri) > double.Parse(m.Ter))
                {
                    soma = double.Parse(m.Seg) + double.Parse(m.Pri);
                }
                //N1 = N3
                else if (double.Parse(m.Pri) == double.Parse(m.Ter))
                {
                    soma = double.Parse(m.Seg);
                }

            }
            //3 MAIOR
            else if (double.Parse(m.Ter) > double.Parse(m.Pri) && double.Parse(m.Ter) > double.Parse(m.Seg))
            {

                // N3 + N2
                if (double.Parse(m.Seg) > double.Parse(m.Pri))
                {
                    soma = double.Parse(m.Ter) + double.Parse(m.Seg);
                }
                // N3 + N1
                else if (double.Parse(m.Pri) > double.Parse(m.Seg))
                {
                    soma = double.Parse(m.Ter) + double.Parse(m.Pri);
                }
                //N2 = N1
                else if (double.Parse(m.Seg) == double.Parse(m.Pri))
                {
                    soma = double.Parse(m.Ter);
                }

            }
            //1 IGUAL AO 2
            else if((double.Parse(m.Pri) == double.Parse(m.Seg)) && ((double.Parse(m.Pri) > double.Parse(m.Ter))
                && double.Parse(m.Seg) > double.Parse(m.Ter)))
            {

                soma = double.Parse(m.Pri) + double.Parse(m.Seg);

            }
            //1 IGUAL AO 3
            else if ((double.Parse(m.Pri) == double.Parse(m.Ter)) && ((double.Parse(m.Pri) > double.Parse(m.Seg))
                && double.Parse(m.Ter) > double.Parse(m.Seg)))
            {

                soma = double.Parse(m.Pri) + double.Parse(m.Ter);

            }
            //2 IGUAL AO 3
            else if ((double.Parse(m.Seg) == double.Parse(m.Ter)) && ((double.Parse(m.Seg) > double.Parse(m.Pri))
                && double.Parse(m.Ter) > double.Parse(m.Pri)))
            {

                soma = double.Parse(m.Seg) + double.Parse(m.Ter);

            }
            //TODOS IGUAIS
            else if (double.Parse(m.Seg) == double.Parse(m.Ter)
                && double.Parse(m.Seg) == double.Parse(m.Pri)
                && double.Parse(m.Pri) == double.Parse(m.Ter))
            {
                soma = double.Parse(m.Seg) + double.Parse(m.Pri);
            }

            return soma;

        }

    }
}