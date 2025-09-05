using System;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using Microsoft.Win32;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quadrado obj1 = new Quadrado();
            //obj1.Lado = 5;
            //obj1.ImprimeArea();
            //Quadrado obj2 = new Quadrado();
            //obj2.Lado = 7;
            //obj2.ImprimeArea();
            //Quadrado obj3 = new Quadrado();
            //obj3.Lado = 8;
            //obj3.ImprimeArea();
            //Quadrado obj4 = new Quadrado();
            //obj4.Lado = 27;
            //obj4.ImprimeArea();
            //Retangulo obj5 = new Retangulo();
            //obj5.altura = 7;
            //obj5.largura = 28;
            //obj5.ImprimeArea();
            //Circulo obj6 = new Circulo();
            //obj6.raio = 23;
            //obj6.ImprimeArea();
            //Triangulo obj7 = new Triangulo();
            //obj7.Altura = 12;
            //obj7.Base = 8;


            //Conta contaGustavo = new Conta();
            //contaGustavo.banco = 001;
            //contaGustavo.agencia = "1234-5";
            //contaGustavo.numero = "67890-1";
            //contaGustavo.saldo = 1000.78;
            //contaGustavo.limite = 500.00;
            //contaGustavo.Depositar(100.12);
            //contaGustavo.Sacar(1600.00);
            //Console.WriteLine($"Saldo atual da conta do Gustavo é de {contaGustavo.ConsultaSaldo():F2}");


            Aluno alunoGustavo = new Aluno();
            alunoGustavo.codigo = 123;
            alunoGustavo.nome = "Gustavo";
            alunoGustavo.lancarNota(1, 7.5);
            alunoGustavo.lancarNota(2, 9.5);
            alunoGustavo.lancarNota(3, 10);
            alunoGustavo.lancarNota(4, 5.4);
            Console.WriteLine($"A média do aluno {alunoGustavo.nome} foi de {alunoGustavo.CalcularMedia()} e ele foi {alunoGustavo.Mencao()}");


        }
    }

    public class Quadrado
    {
        public int Lado;

        public int CalcularArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($" Quadrado com lado de {Lado} possui uma área de {CalcularArea()}");
        }

    }


    public class Retangulo
    {
        public int altura;
        public int largura;
        public int CalcularArea()
        {
            int area = altura * largura;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($" Retângulo com altura de {altura} e largura de {largura} possui uma área de {CalcularArea()}");
        }
    }

    public class Circulo 
    {
        public double raio;

        public double CalcularArea()
        {
            double area = Math.Pow(raio, 2) * Math.PI;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($" Círculo com raio de {raio} possui uma área de {CalcularArea():F2}");
        }

    }

    public class Triangulo 
    { 
        public double Base;
        public double Altura;

        public double CalcularArea() 
        {
            double area = (Base * Altura) / 2;
            return area;
        }
        
        public void ImprimeArea()
        {
            Console.WriteLine($" Triângulo com base de {Base} e altura de {Altura} possui uma área de {CalcularArea()}");
        }

    }

    public class Conta 
    {
        public int banco;
        public string agencia;
        public string numero;
        public double saldo;
        public double limite;

        public void Depositar(double valor)
        {
            saldo = valor + saldo;
        }

        public void Sacar(double valor)
        {

            saldo = saldo - valor;


            if (saldo - valor < 0 )
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

                
        }

        public double ConsultaSaldo()
        {
            
            return saldo;
        }
    }


    public class Aluno
    {
        public int codigo;
        public string nome;
        public double[] nota = new double[4];


        public void lancarNota (int semestre, double notaSemestre)
        {

            for (int i = 0; i < nota.Length; i++)
            {
                if (semestre == i + 1)
                {
                    nota[i] = notaSemestre;
                }
            }
        }

        public double CalcularMedia()
        {
            double soma = 0;
            for (int i = 0; i < nota.Length; i++)
            {
                soma = soma + nota[i];
            }
            double media = soma / 4;
            return media;
        }

        public string Mencao() 
        { 
            if (CalcularMedia() >= 5)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }

        }
    }
}
