using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_RefatoracaoValidadorCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu CPF: ");
            string cpf = Console.ReadLine();
            IDocumento documento = new CPF(cpf);
            Console.WriteLine(documento.Validar());
        }
    }
}
