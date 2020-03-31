using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficientException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        //é uma convenção no .NET criar um construtor sem argumentos para os tipos de exceções 
        public SaldoInsuficientException()
        {
        }
        //this faz referencia a outro metodo construtor de sua propria classe 
        public SaldoInsuficientException(double saldo, double valorSaque)
            : this("Tentativa de saque no valor de R$ " + valorSaque + " em uma conta com saldo de R$ " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficientException(string mensagem) : base(mensagem)
        {
        }
    }
}
