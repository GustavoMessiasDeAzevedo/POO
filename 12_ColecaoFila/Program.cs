using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string>filaAtendimento = new Queue<string>();
            int i = 1;
            while (true)
            {
                
                Console.Write($"Digite o {i} nome: ");
                string nome = Console.ReadLine();
                if (!string.IsNullOrEmpty(nome) && nome.Length >= 3)
                {
                    filaAtendimento.Enqueue(nome);
                    i++;
                }
                    
                Console.WriteLine("Deseja adicionar mais um nome na lista? (S/N)");
                if (Console.ReadLine().ToUpper() == "N")
                    break;
            }

            Console.WriteLine($"\nExistem {filaAtendimento.Count} pessoas na fila.");
            Console.WriteLine($"\nE a primeira pessoa a ser atendida na fila foi: {filaAtendimento.Dequeue()}");
            Console.WriteLine($"\nE a segunda pessoa a ser atendida na fila foi: {filaAtendimento.Dequeue()}");
            Console.WriteLine($"\nE a terceira pessoa a ser atendida na fila foi: {filaAtendimento.Dequeue()}");
            Console.WriteLine($"\nAinda restam {filaAtendimento.Count} pessoas na fila.");
  
            foreach (string pessoa in filaAtendimento)
            {
                Console.WriteLine($" - {pessoa}");
            }
        }
    }
}
