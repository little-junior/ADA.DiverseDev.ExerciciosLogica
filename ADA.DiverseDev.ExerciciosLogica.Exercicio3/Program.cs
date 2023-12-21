namespace ADA.DiverseDev.ExerciciosLogica.Exercicio3
{
    using ADA.DiverseDev.ExerciciosLogica.Exercicio3.Lib;
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Menu.ReceberEntrada(out long numero);
                
                if (numero == -1)
                {
                    Environment.Exit(0);
                }
                
                Console.Clear();
                long resultadoFatorial = Fatorial.Calcular(numero);

                Console.WriteLine($"Fatorial de {numero} = {resultadoFatorial}");
                Console.ReadKey();
            }
        }
    }
}
