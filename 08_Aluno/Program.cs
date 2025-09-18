using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Aluno aluno = new Aluno(nome);

            Console.WriteLine("Digite a idade do aluno: ");
            aluno.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {aluno.Nome} Idade: {aluno.Idade} 1° Nota: {aluno.Nota1} 2° Nota: {aluno.Nota2} Media: {aluno.Media} Situação: {aluno.Situacao}");


        }


        public class Aluno
        {
            private string nome;

            private int idade;

            private double nota1;

            private double nota2;

            public double Nota1 { get; set; }

            public double Nota2 { get; set; }

            public string Nome { get; }
            public int Idade
            {
                get { return idade; }
                set {
                    if (value >= 0)
                        idade = value;
                    else
                        Console.WriteLine("Idade inválida");
                }
            }


            public Aluno(string Nome)
            {
                this.nome = Nome;

                
            }
            public double Media
            {
                get { return (Nota1 + Nota2) / 2; }
            }

            public string Situacao
            {
                get
                {
                    if (Media >= 6)
                        return "Aprovado";
                    else
                        return "Reprovado";
                }
            }

        }
    }
}
