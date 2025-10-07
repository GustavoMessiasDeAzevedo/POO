using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _21_ValidaCPNJComExcecao
{
    public class CNPJ : IDocumento
    {
        public string Numero { get; private set; }

        public CNPJ(string numero)
        {
            Numero = Regex.Replace(numero, @"[^0-9]", "");

            if (Numero.Length != 14)
                throw new CNPJQtdeDigitosException();

            if (this.Numero.Distinct().Count() == 1)
                throw new CNPJMesmoNumeroException();
        }


        public bool Validar()
        {
            int[] numeroCPNJ = new int[Numero.Length];

            for (int i = 0; i < Numero.Length; i++)
                numeroCPNJ[i] = int.Parse(Numero[i].ToString());

            int[] mult1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;

            for (int i = 0; i < mult1.Length; i++)
                soma += numeroCPNJ[i] * mult1[i];

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;
            if (numeroCPNJ[12] != digito1)
                return false;

            soma = 0;
            for (int i = 0; i < mult2.Length; i++)
                soma += numeroCPNJ[i] * mult2[i];
            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;
            if (numeroCPNJ[13] != digito2)
                return false;

            if (numeroCPNJ[12] == digito1 && numeroCPNJ[13] == digito2)
            {
                Console.WriteLine("CNPJ é válido");
                return true;
            }
            else
                return false;

        }
    }
}
