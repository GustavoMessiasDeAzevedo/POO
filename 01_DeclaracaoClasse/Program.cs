using System;
using System.Runtime.Remoting.Messaging;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();
            Quadrado obj2 = new Quadrado();
            obj2.Lado = 7;
            obj2.ImprimeArea();
            Quadrado obj3 = new Quadrado();
            obj3.Lado = 8;
            obj3.ImprimeArea();
            Quadrado obj4 = new Quadrado();
            obj4.Lado = 27;
            obj4.ImprimeArea();
            Retangulo obj5 = new Retangulo();
            obj5.altura = 7;
            obj5.largura = 28;
            obj5.ImprimeArea();
            Circulo obj6 = new Circulo();
            obj6.raio = 23;
            obj6.ImprimeArea();
            Triangulo obj7 = new Triangulo();
            obj7.Altura = 12;
            obj7.Base = 8;
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
}
