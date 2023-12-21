using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio1.Lib
{
    public static class Conversoes
    {
        public static double ConverterCparaF(double valCelsius)
        {
            double resultado = (valCelsius * 9 / 5) + 32;


            return resultado;
        }

        public static double ConverterFparaC(double valFahrenheit)
        {
            double resultado = (valFahrenheit - 32) / 1.8;

            return resultado;
        }
    }
}
