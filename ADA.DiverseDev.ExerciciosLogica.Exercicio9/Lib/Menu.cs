using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio9.Lib
{
    public static class Menu
    {
        public static void Principal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite o CPF no formato XXX.XXX.XXX-XX (0 para sair): ");
                string? cpf = Console.ReadLine();
                VerificarSaida(cpf);
                if (!CPF.VerificarFormato(cpf))
                {
                    Console.WriteLine("\nFORMATO INVÁLIDO. TENTE NOVAMENTE");
                    Console.ReadKey();
                    continue;
                }

                if (CPF.IsCpf(cpf))
                {
                    Console.WriteLine("\nCPF VÁLIDO.");
                }
                else
                {
                    Console.WriteLine("\nCPF INVÁLIDO.");
                }

                Console.ReadKey();

            }
        }

        public static void VerificarSaida(string? entrada)
        {
            if (entrada == "0")
            {
                Environment.Exit(0);
            }
        }
    }
}
