using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    public class CPFMesmoNumeroException :Exception
    {
        public CPFMesmoNumeroException() : base("CPF INVÁLIDO! Não pode conter todos os dígitos iguais.")
        {
        }
    }
}
