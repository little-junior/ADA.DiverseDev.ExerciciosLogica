using ADA.DiverseDev.ExerciciosLogica.Exercicio7.Lib;
using System.Globalization;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Digite o valor em reais (0 para sair): ");
                Menu.ReceberValorReais(out decimal valorReais);

                if (valorReais == 0) { Environment.Exit('0'); }

                Console.Write("Digite a cotação: ");
                Menu.ReceberCotacao(out decimal cotacao);

                decimal valorDolar = Conversor.ConverterRealDolar(valorReais, cotacao);

                Menu.ImprimirConversão(valorReais, valorDolar);
            }
        }

        
    }


}
