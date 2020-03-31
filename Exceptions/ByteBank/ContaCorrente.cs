// msdn é a documentação para o c#

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TaxaOperacao;
        public static int TotalDeContasCriadas { get; private set; }
        
        //quando declaramos só o get, ele cria o setter privado readonly(somente leitura)
        // dessa forma "private readonly int _numero;"
        //e o tipo somente leitura, o setter dele só poderá ser excutado em um metodo construtor.
        //trazendo segurança de que ele não poderá ser alterado
        public int Numero { get; }
        public int Agencia { get; }
        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));//o nameof retorna uma string com o nome do metodo, então o retorno será "agencia" e não o valor que está em agencia
            }
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }
            if (_saldo < valor)
            {
                throw new SaldoInsuficientException(Saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            }

            //utilizando a logica de sacar pois ambas possuem a mesma finalidade "_saldo -= valor;"
            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
