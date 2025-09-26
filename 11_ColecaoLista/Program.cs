using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            Console.WriteLine("Digite quantos nomes gostaria de acrescentar na lista: ");
            int contador = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= contador; i++)
            {
                Console.Write($"Digite o {i}º nome: ");
                string nome = Console.ReadLine();

                if(!string.IsNullOrEmpty(nome) && nome.Length >= 3)
                {
                    nomes.Add(nome);
                }
            }

            foreach (string nome in nomes)
            {
                Console.WriteLine($"\n - {nome}");
            }
        }
    }
}
