using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio3.Lib
{
    internal static class Fatorial
    {
        public static long Calcular(long num)
        {
            if (num == 0)
                return 1;

            return num * Calcular(num - 1);
        }
    }
}
