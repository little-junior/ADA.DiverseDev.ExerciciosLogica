using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio2.Lib
{
    internal static class PrimoUtilities
    {
        public static bool IsPrimo(int num, List<int> listaFatores)
        {
            if (num == 1)
            {
                listaFatores.Add(1);
                return false;
            }

            bool primo = true;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                    listaFatores.Add(i);
                }

            }

            return primo;
        }


        public static void ImprimirDivisiveis(bool verificacao, List<int> fatores)
        {
            if (!verificacao)
            {
                Console.Write("Divisível por: ");
                for (int i = 0; i <  fatores.Count; i++)
                {
                    if (i == 16)
                    {
                        Console.Write("...");
                        break;
                    }

                    Console.Write(fatores[i] + " ");
                }
            }
        }

    }
}
