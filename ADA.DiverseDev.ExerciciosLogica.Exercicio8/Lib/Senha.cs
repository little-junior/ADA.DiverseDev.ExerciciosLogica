using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio8.Lib
{
    public static class Senha
    {

        public static bool IsSenha(string? senha)
        {
            string mensagemErro = "\nA senha:\n";
            bool lancarErro = false;

            if (string.IsNullOrEmpty(senha))
            {
                mensagemErro += "\n-Não pode ser vazia";
                lancarErro = true;
            }

            if (senha.Length < 8) {
                mensagemErro += "\n-Deve conter 8 ou mais caracteres.";
                lancarErro = true;
            }

            if (!senha.Any(char.IsUpper))
            {
                mensagemErro += "\n-Deve conter pelo menos uma letra maiuscula.";
                lancarErro = true;
            }

            if (!senha.Any(char.IsLower))
            {
                mensagemErro += "\n-Deve conter pelo menos uma letra minuscula.";
                lancarErro = true;
            }

            if(!senha.Any(char.IsNumber))
            {
                mensagemErro += "\n-Deve conter pelo menos um numero.";
                lancarErro = true;
            }

            if (lancarErro)
            {
                throw new Exception(mensagemErro);
            }

            return true;
        }
    }
}
