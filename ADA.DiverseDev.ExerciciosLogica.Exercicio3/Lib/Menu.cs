using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio3.Lib
{
    internal class Menu
    {
        public static void ReceberEntrada(out long numero)
        {
            Console.Write("Digite um número inteiro positivo (-1 para sair): ");
            while (!long.TryParse(Console.ReadLine(), out numero) || numero < -1)
            {
                Console.Write("Por favor, digite um número que obedeça a regra: ");
            }
        }
    }
}
