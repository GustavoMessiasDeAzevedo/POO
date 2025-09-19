using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Herança
{
    public abstract class Pessoa
    {
        public string Nome;

        public abstract string GetDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"Nome: {this.Nome} Documento: {this.GetDocumento()}");
        }
    }
}
