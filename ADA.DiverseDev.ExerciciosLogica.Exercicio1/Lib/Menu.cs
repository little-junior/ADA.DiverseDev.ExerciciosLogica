using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio1.Lib
{
    public static class Menu
    {
        public static string Titulo = "  ____                                               _           \r\n / ___|___  _ ____   _____ _ __ ___  ___  _ __    __| | ___      \r\n| |   / _ \\| '_ \\ \\ / / _ \\ '__/ __|/ _ \\| '__|  / _` |/ _ \\     \r\n| |__| (_) | | | \\ V /  __/ |  \\__ \\ (_) | |    | (_| |  __/     \r\n \\____\\___/|_| |_|\\_/ \\___|_|  |___/\\___/|_|     \\__,_|\\___|     \r\n|_   _|__ _ __ ___  _ __   ___ _ __ __ _| |_ _   _ _ __ __ _ ___ \r\n  | |/ _ \\ '_ ` _ \\| '_ \\ / _ \\ '__/ _` | __| | | | '__/ _` / __|\r\n  | |  __/ | | | | | |_) |  __/ | | (_| | |_| |_| | | | (_| \\__ \\\r\n  |_|\\___|_| |_| |_| .__/ \\___|_|  \\__,_|\\__|\\__,_|_|  \\__,_|___/\r\n                   |_|                                           \r\n\r\n";

        public static void ExibirOpcoes()
        {
            
            Console.Write("1 - Celsius para Fahrenheit\n2 - Fahrenheit para Celsius\n3 - Sair\n\n");
        }

        public static void ExibirTitulo()
        {
            Console.Clear();
            Console.WriteLine(Titulo);
        }

        public static void LerOpcao(out char escolha)
        {
            do
            {
                Console.WriteLine("Digite a opção ");
            } while (!char.TryParse(Console.ReadLine(), out escolha));
        }

        public static void ReceberEntrada(out double temperaturaDesejada)
        {
            Console.Write("Digite a temperatura: ");
            while (!double.TryParse(Console.ReadLine(), out temperaturaDesejada))
            {
                Console.Write("Digite a temperatura válida: ");
            }
        }
    }
}