using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio5.Lib
{
    internal static class Menu
    {
        public static void ReceberPalavra(out string palavra)
        {
            Console.Write("Digite apenas UMA palavra válida (0 para sair): ");
            palavra = Console.ReadLine().Trim().ToLower();

            ConferirSaida(palavra);

            if (string.IsNullOrEmpty(palavra) || !ConferirPalavra(palavra))
            {
                throw new Exception("Palavra não válida. Tente novamente.");
            }


        }

        private static bool ConferirPalavra(string palavra)
        {
            foreach(var letra in palavra.ToCharArray())
            {
                

                if (!Char.IsLetter(letra))
                {
                    return false;
                }

            }
            return true;
        }

        private static void ConferirSaida(string palavra)
        {
            if (palavra.Length == 1 && palavra[0] == '0')
                Environment.Exit(0);
        }
    }
}
