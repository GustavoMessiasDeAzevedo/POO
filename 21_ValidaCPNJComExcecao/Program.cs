using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ValidaCPNJComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDocumento documento;

            while (true)
            {
                Console.WriteLine("Digite um CPNJ: ");

                try
                {
                    documento = new CNPJ(Console.ReadLine());
                    break;
                }
                catch (CNPJQtdeDigitosException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (CNPJMesmoNumeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CNPJ inválido: {ex.Message}");
                }
                finally
                {
                    Console.Clear();
                }
           
            }
            Console.WriteLine(documento.Validar());
        }
    }
}
