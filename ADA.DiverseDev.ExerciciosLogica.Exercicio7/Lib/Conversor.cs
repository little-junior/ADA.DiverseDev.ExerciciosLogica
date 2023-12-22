using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio7.Lib
{
    internal static class Conversor
    {
        public static decimal ConverterRealDolar(decimal reais, decimal cotacao)
        {
            return reais / cotacao;
        }
    }
}
