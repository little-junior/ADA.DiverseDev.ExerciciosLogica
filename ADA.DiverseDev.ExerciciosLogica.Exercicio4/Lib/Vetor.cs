using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio4.Lib
{
    internal static class Vetor
    {
        public static void Ordenar(double[] vetor)
        {
            double temp;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        temp = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = temp;
                    }
                }
            }
        }


        public static void ReceberValores(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"vetor[{i}]: ");
                while (!double.TryParse(Console.ReadLine(), out vetor[i]))
                {
                    Console.Write("Por favor, digite um número válido: ");
                }
            }
        }
    }
}
