using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>();

            Console.Write("Quantos alunos deseja adicionar: ");
            int qtdAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                // Verifica se o nome não é nulo/vazio e tem mais de 3 caracteres
                if (!string.IsNullOrEmpty(nome) && nome.Length > 3)
                {
                    Console.Write("Digite a matricula do aluno: ");
                    int matricula = int.Parse(Console.ReadLine());
                    alunos.Add(matricula, nome);
                }
                else
                {
                    Console.WriteLine("Nome inválido! (precisa ter mais de 3 letras).");
                }
            }

            Console.WriteLine("\nLista de alunos cadastrados:");

            // Exibe os alunos cadastrados
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Matrícula: {aluno.Key} - Nome: {aluno.Value}");
            }
        }
    }
}
