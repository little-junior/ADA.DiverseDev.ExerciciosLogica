using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio7.Lib
{
    internal static class Menu
    {
        public static void ReceberValorReais(out decimal valorReais)
        {
            while (!decimal.TryParse(Console.ReadLine(), out valorReais) || valorReais < 0)
            {
                Console.Write("Digite o valor em reais VALIDO: ");
            }
        }

        public static void ReceberCotacao(out decimal cotacao)
        {
            while (!decimal.TryParse(Console.ReadLine(), out cotacao) || cotacao <= 0) {
                Console.Write("Digite a cotação VALIDA: ");
            }
        }

        public static void ImprimirConversão(decimal valorReais, decimal valorDolar)
        {
            Console.Clear();
            Console.WriteLine($"{valorReais:C3} -> {valorDolar.ToString("C3", CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.ReadKey();
        }
    }
}
