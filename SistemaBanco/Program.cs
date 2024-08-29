using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contaBancaria instConta = new contaBancaria();
            dadosConta instDados = new dadosConta();
            
            Console.WriteLine("Sistema de Banco");
            Console.WriteLine("Saldo Atual: R$ "+instDados.acessoSaldo);
            Console.Write("Digite o saldo a ser adicionado: ");
            instConta.acessoSaldo = Console.ReadLine();
        }
    }
}