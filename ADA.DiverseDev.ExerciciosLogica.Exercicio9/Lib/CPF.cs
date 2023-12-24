using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.DiverseDev.ExerciciosLogica.Exercicio9.Lib
{
    internal class CPF
    {
        public static bool VerificarFormato (string? cpf)
        {
            if (string.IsNullOrEmpty(cpf))
            {
                return false;
            }   

            if (cpf.Length != 14)
            {
                return false;
            }

            if (cpf.Count(c => c == '-') != 1 || cpf.Count(c => c == '.') != 2)
            {
                return false;
            }

            if (cpf[3] != '.' || cpf[7] != '.' || cpf[11] != '-')
            {
                return false;
            }

            return true;
        }

        public static bool IsCpf(string cpf)
        {
            string cpfFormatado = cpf.Trim().Replace("-", "").Replace(".", "");

            bool formatacaoSucedida = long.TryParse(cpfFormatado, out long cpfNums);

            if (!formatacaoSucedida)
            {
                return false;
            }

            if (cpfFormatado.All(n => n.Equals(cpfFormatado[0])))
            {
                return false;
            }

            int[] verificadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] verificadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int count1 = 0;
 
            for (int i = 0; i < verificadores1.Length; i++)
            {
                count1 += int.Parse(cpfFormatado[i].ToString()) * verificadores1[i];
            }

            int resto1 = count1 % 11;

            if (resto1 < 2)
            {
                if (cpfFormatado[9] != '0')
                {
                    return false;
                }
            }else if(int.Parse(cpfFormatado[9].ToString()) != 11 - resto1)
            {
                return false;
            }
            

            int count2 = 0;

            for (int i = 0; i < verificadores2.Length; i++)
            {
                count2 += int.Parse(cpfFormatado[i].ToString()) * verificadores2[i];
            }

            int resto2 = count2 % 11;

            if (resto2 < 2)
            {
                if (cpfFormatado[10] != '0')
                {
                    return false;
                }
            } else if (int.Parse(cpfFormatado[10].ToString()) != 11 - resto2)
            {
                return false;
            }
            
            return true;
        }
    }
}
