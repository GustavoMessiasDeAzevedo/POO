using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Gustavo";
            pessoaFisica.CPF = "123.456.789-00";
            pessoaFisica.Telefone = "(11) 91234-5678";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Giovana";
            pessoaJuridica.CNPJ = "12.345.678/0001-00";
            pessoaJuridica.Telefone = "(11) 98765-4321";
            pessoaJuridica.Imprimir();
        }
    }
}
