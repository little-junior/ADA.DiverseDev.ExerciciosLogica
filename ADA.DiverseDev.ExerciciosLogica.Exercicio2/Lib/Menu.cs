using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio2.Lib
{
    internal static class Menu
    {
        public static void ReceberEntrada(out int numero)
        {
            Console.Write("Digite um número inteiro maior do que 0 (0 para sair): ");
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Por favor, digite um número que obedeça a regra: ");
            }
        }
    }
}
