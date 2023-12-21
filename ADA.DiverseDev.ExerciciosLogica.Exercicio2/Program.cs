using ADA.DiverseDev.ExerciciosLogica.Exercicio2.Lib;
using System.Runtime.Intrinsics.Arm;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                List<int> fatores = new();
                Menu.ReceberEntrada(out int numero);
                Console.Clear();

                if (numero == 0)
                {
                    Environment.Exit(0);
                }

                bool verificacao = PrimoUtilities.IsPrimo(numero, fatores);
                Console.WriteLine($"{numero} É primo? -> {verificacao}");

                PrimoUtilities.ImprimirDivisiveis(verificacao, fatores);

                Console.ReadKey();
            }
        }
    }


}
