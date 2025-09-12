using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Conta conta = new Conta("12345-X", "Gustavo Messias");
            //conta.saldo = -1000.00m;
            //conta.Depositar(-1000.00m);

            //utilizando os metodos acessadores
            conta.setSaldo(1000.00m);
            conta.ImprimirSaldo();
            
 

            while (true)
            {
                Console.WriteLine("Informe a operação: [D] - Depositar, [S] - Sacar ou [E] - Sair");
                string operacao = Console.ReadLine().ToUpper();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para deposito:");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque:");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.getNumero()} nome: {conta.getNome()} Saldo: {conta.getSaldo()}" );
                    break;
                }
                else
                {
                    Console.WriteLine("Use somente: [D] - Depositar, [S] - Sacar ou [E] - Sair");
                }
            }
        }
    }


    public class Conta
    {
        private string numero { get; }
        private string nome { get; }        //public decimal Saldo;        
        private decimal saldo;
        //metodos acessadores
        public decimal getSaldo()
        {
            return saldo;
        }
        
        public Conta(string numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
        }

        public string getNumero()
        {
            return numero;
        }

        public string getNome()
        {
            return nome;
        }
        public void setSaldo(decimal saldo)
        {
            this.Depositar(saldo);
        }

        public void Depositar(decimal valor)
        {
            if(valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor de depósito incorreto, deve ser mair que zero!");
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public void ImprimirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo:C3} o numero da conta é: {numero}");
        }
    }
}
