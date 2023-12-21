namespace ADA.DiverseDev.ExerciciosLogica.Exercicio1
{
    using ADA.DiverseDev.ExerciciosLogica.Exercicio1.Lib;
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.ExibirTitulo();
                Menu.ExibirOpcoes();
                double temperaturaDesejada;
                Menu.LerOpcao(out char escolha);

                Menu.ExibirTitulo();
                switch (escolha)
                {
                    case '1':
                        Console.WriteLine("Opção escolhida: Celsius para Fahrenheit");
                        Menu.ReceberEntrada(out temperaturaDesejada);
                        Console.WriteLine($"\nTemperatura convertida: {Conversoes.ConverterCparaF(temperaturaDesejada):0.00}");
                        break;
                    case '2':
                        Console.WriteLine("Opção escolhida: Fahrenheit para Celsius");
                        Menu.ReceberEntrada(out temperaturaDesejada);
                        Console.WriteLine($"\nTemperatura convertida: {Conversoes.ConverterFparaC(temperaturaDesejada):0.00}");
                        break;
                    case '3':
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada. Tente novamente");
                        break;
                }

                Console.ReadKey();

            }
        }
    }
}
