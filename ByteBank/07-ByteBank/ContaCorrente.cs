// using seria usado caso esta classe não estivesse no mesmo namespace
// using _05_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        //Quando não há regra especifica de négocio, podemos criar get e set dessa forma, pois fazem os comandos padrões de um get e set
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;
        private int _agencia;
        //static é um atributo reservado da classe, só conseguimos utilizar se invocar a classe
        //exemplo ContaCorrente.TotalDeContasCriadas
        //ao utilizar o static dizemos que TotalDeContasCriados é uma propriedade da classe
        public static int TotalDeContasCriadas { get; private set; }

        //metodo para fazer o get e set
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

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        //metodo construtor, para evitar que a pessoa esqu~eça de criar uma conta corrente sem a agencia e o numero
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Trasferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}