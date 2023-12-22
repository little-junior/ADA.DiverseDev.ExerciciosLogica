using ADA.DiverseDev.ExerciciosLogica.Exercicio4.Lib;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.ReceberTamanho(out int tamanho);
                Menu.VerificarSaida(tamanho);

                double[] vetor = new double[tamanho];
                
                Console.Clear();
                Vetor.ReceberValores(vetor);

                Vetor.Ordenar(vetor);

                Menu.ImprimirVetor(vetor);
            }
        }
    }
}   
