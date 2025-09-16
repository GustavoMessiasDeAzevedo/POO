using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno gustavo = new Aluno("Gustavo Messias", 18, 8, 7);
            gustavo.Resultado();


        }


        public class Aluno
        {
            private string nome;

            private int idade;

            private double nota1;

            private double nota2;

            private double media;

            private string situacao;

            
            public string Nome
            {
               get { return nome; }
               private set { nome = value; }
            }

            public int Idade
            {
                get { return idade; }
                set { idade = value; }
            }


            public Aluno(string Nome, int Idade, double Nota1, double Nota2)
            {
                this.nome = Nome;
                this.idade = Idade;
                this.nota1 = Nota1;
                this.nota2 = Nota2;
                
            }
            public double Media
            {
                get { return (nota1 + nota2) / 2; }
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

            public void Resultado()
            {
                Console.WriteLine($"Nome: {nome}, Idade: {idade} anos, sua média foi de: {Media} e você foi: {Situacao}");
            }

        }
    }
}
