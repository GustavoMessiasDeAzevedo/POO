using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ValidaCPNJComExcecao
{
    public class CNPJQtdeDigitosException : Exception
    {
        public CNPJQtdeDigitosException() : base("CNPJ inválido: Insira 14 numeros por favor!")
        {
        }
    }
}
