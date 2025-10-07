using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    public class CPF : IDocumento
    {
        public string Numero { get; }

       public CPF(string numero)
        {
            Numero = Regex.Replace(numero, @"[^0-9]", "");

            if(Numero.Length != 11)
                throw new CPFQtdeDigitosException();

            if (this.Numero.Distinct().Count() == 1)
                throw new Exception("CPF INVÁLIDO! Não pode conter todos os dígitos iguais.");
        }


        public bool Validar()
        {

            int[] numeroCPF = new int[Numero.Length];

            for (int i = 0; i < Numero.Length; i++)
            {
                numeroCPF[i] = int.Parse(Numero[i].ToString());
            }

            if (Numero.Length == 11)
            {
                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += numeroCPF[i] * (10 - i);
                }
                int resto = soma % 11;
                int digito1 = (resto < 2) ? 0 : 11 - resto;

                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += numeroCPF[i] * (11 - i);
                }
                resto = soma % 11;
                int digito2 = (resto < 2) ? 0 : 11 - resto;
                if (digito1 == numeroCPF[9] && digito2 == numeroCPF[10])
                {
                    //Console.WriteLine("CPF VÁLIDO!");
                    return true;
                }
                else
                {
                    //Console.WriteLine("CPF INVÁLIDO!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
