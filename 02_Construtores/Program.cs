using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(5);
            quadrado.ImprimirArea();

            Retangulo retangulo = new Retangulo(14, 74);
            retangulo.ImprimirArea();

            Circulo circulo = new Circulo(27);
            circulo.ImprimirArea();

            Triangulo triangulo = new Triangulo(23, 21);
            triangulo.ImprimirArea();
        }       
    }

    public class Quadrado 
    {
        //Pode ser usado só dentro da classe (private)
        private int Lado;

        public Quadrado(int Lado)
        {
            this.Lado = Lado;
        }

        public int CalculaArea() 
        { 
            return Lado * Lado;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Quadrado com com lado de {Lado} possui uma área de {CalculaArea()}");
        }
    }

    public class Retangulo 
    {
        private int Base;
        private int Altura;

        public Retangulo(int Base, int Altura) 
        { 
            this.Base = Base;
            this.Altura = Altura;
        }


        public int CalculaArea()
        {
            return Base * Altura;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Retângulo com com base de {Base} e altura de {Altura} possui uma área de {CalculaArea()}");
        }

    }

    public class Circulo 
    { 
        private double Raio;

        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }

        public double CalculaArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio} possui uma área de {CalculaArea():F2}");
        }

    }

    public class Triangulo 
    { 
        private double Base;
        private double Altura;

        public Triangulo(double Base, double Altura) 
        { 
            this.Base = Base;
            this.Altura = Altura;
        }

        public double CalculaArea()
        {
            return (Base * Altura) / 2;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Triângulo com com base de {Base} e altura de {Altura} possui uma área de {CalculaArea()}");
        }
    }
}
