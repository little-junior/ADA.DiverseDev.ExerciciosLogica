using ADA.DiverseDev.ExerciciosLogica.Exercicio5.Lib;


namespace ADA.DiverseDev.ExerciciosLogica.Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Menu.ReceberPalavra(out string palavra);
                    Console.WriteLine($"\n{palavra} é palindromo? -> {Palindromo.IsPalindromo(palavra)}");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    continue;
                }

            }
        }

        
    }
}
