using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio4.Lib
{
    internal static class Menu
    {
        public static void ImprimirVetor(double[] vetor)
        {
            Console.Clear();
            Console.WriteLine("Vetor ordenado: ");
            Console.WriteLine(string.Join(" ", vetor));
            Console.ReadKey();
            Console.Clear();
        }

        public static void VerificarSaida(int entrada)
        {
            if (entrada == 0)
            {
                Environment.Exit(0);
            }
        }

        public static void ReceberTamanho(out int tamanho)
        {
            Console.Write("Digite o tamanho do vetor (0 para sair): ");
            while (!int.TryParse(Console.ReadLine(), out tamanho) || tamanho < 0)
            {
                Console.Write("Por favor, digite um número inteiro válido: ");
            }
        }

    }
}
