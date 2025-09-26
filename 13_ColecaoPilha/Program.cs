using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> pilhaNumeros = new Stack<int>();

            Console.Write("Quantos numeros deseja adicionar: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}º numero: ");
                int numero = int.Parse(Console.ReadLine());
                pilhaNumeros.Push(numero);
            }

            Console.WriteLine($"O ultimo numero a ser acrescentado foi: {pilhaNumeros.Peek()}");
        }
    }
}
