using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio5.Lib
{
    internal static class Palindromo
    {
        public static bool IsPalindromo(string palavra)
        {
            string palavraInvertida = string.Join("", palavra.Reverse());

            return palavra == palavraInvertida;
        }
    }
}
