using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int>();

            Console.Write("Quantos numeros deseja adicionar: ");
            int quantidade = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite um numero: ");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
