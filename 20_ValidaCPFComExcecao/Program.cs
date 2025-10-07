using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDocumento documento;
            while (true)
            {
                Console.WriteLine("Digite o seu CPF: ");
                try
                {
                    documento = new CPF(Console.ReadLine());
                    break;
                }
                catch(CPFQtdeDigitosException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CPF Inválido!: {ex.Message}");
                }
            }
            Console.WriteLine(documento.Validar());
        }
    }
}
