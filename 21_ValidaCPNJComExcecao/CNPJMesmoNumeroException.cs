using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ValidaCPNJComExcecao
{
    public class CNPJMesmoNumeroException : Exception
    {
        public CNPJMesmoNumeroException() : base("CNPJ inválido: todos os números são iguais.")
        {
        }
    }
}
