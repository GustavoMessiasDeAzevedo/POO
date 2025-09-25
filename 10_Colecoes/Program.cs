using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generico                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
            List<string> nomes = new List<string>();
            nomes.Add("Gustavo");
            nomes.Add("Bianca");

            List<Aluno> alunos = new List<Aluno>();
            Aluno gustavo = new Aluno { id = 1, nome = "Gustavo"};
            AlunoEspecial bianca = new AlunoEspecial { id = 2, nome = "Bianca", Deficiencia = "Visual" };
            alunos.Add(gustavo);
            alunos.Add(bianca);

            alunos.Add(new Aluno { id = 3, nome = "Giovana" });
            nomes.Add(gustavo.nome);

            Console.WriteLine("Impressão dos nomes");
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("\nImpressão dos nomes");
            foreach (Aluno aluno in alunos)
            {
                //Console.WriteLine($"Id: {aluno.id} - Nome: {aluno.nome}");
                aluno.ImprimirAluno();
            }

            Dictionary<int, string> dicNomes = new Dictionary<int, string>();
            dicNomes.Add(1, "Gustavo");
            dicNomes.Add(2, "Bianca");
            dicNomes.Add(3, "Giovana");
            
            //Não pode adicionar chave repetida
            
            Console.WriteLine("\nImpressão dos dicNomes");

            for (int i = 1; i <= dicNomes.Count; i++)
            {
                Console.WriteLine($" - {dicNomes[i]}");
            }


            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
            dicAlunos.Add(gustavo.id, gustavo);
            dicAlunos.Add(bianca.id, bianca);

            Console.WriteLine("\nImpressão dos dicAlunos");
            //for (int i = 1; i <= dicAlunos.Count; i++)
            //{
            //    dicAlunos[i].ImprimirAluno();
            //}

            foreach(Aluno aluno in dicAlunos.Values)
            {
                aluno.ImprimirAluno();
            }
    }


    class Aluno
    {
        public int id { get; set; }
        
        public string nome { get; set; }
        
        public double[] notas { get; set; }

        public virtual void ImprimirAluno()
        {
            Console.WriteLine($"- ID: {this.id} Nome: {this.nome}");
        }

  
    }

    class AlunoEspecial : Aluno
    {
        public string Deficiencia { get; set; }

        public override void ImprimirAluno()
        {
            Console.WriteLine($"- ID: {this.id} Nome: {this.nome} - {this.Deficiencia}");
        }
    }
}
