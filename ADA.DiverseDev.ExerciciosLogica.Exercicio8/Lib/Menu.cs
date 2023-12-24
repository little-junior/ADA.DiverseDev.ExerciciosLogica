using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ADA.DiverseDev.ExerciciosLogica.Exercicio8.Lib
{
    public class Menu
    {
        public static void Principal()
        {
            Console.Clear();
            Console.WriteLine("Crie uma senha que atenda aos seguintes critérios:");
            Console.WriteLine("- Pelo menos 8 caracteres");
            Console.WriteLine("- Pelo menos uma letra maiúscula");
            Console.WriteLine("- Pelo menos uma letra minúscula");
            Console.WriteLine("- Pelo menos um número");
            Console.ReadKey();

            while (true)
            {
                Console.Clear();

                string? senha = ReceberSenha();
                VerificarSaida(senha);

                try
                {
                    bool verificacaoSenha = Senha.IsSenha(senha);
                    Console.WriteLine("\nSenha criada com sucesso.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadKey();
                }


            }
        }

        private static void VerificarSaida(string? entrada)
        {
            if (entrada == "0")
            {
                Console.Clear();
                Console.WriteLine("Saindo...");
                Thread.Sleep(2000);
                Console.Clear();
                Environment.Exit(0);
            }
        }

        private static string? ReceberSenha()
        {
            Console.Write("Digite a senha (0 para sair): ");
            return Console.ReadLine();
        }

    }
}
