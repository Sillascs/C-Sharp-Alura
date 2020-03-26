// using seria usado caso esta classe não estivesse no mesmo namespace
// using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        
        //Quando não há regra especifica de négocio, podemos criar get e set dessa forma, pois fazem os comandos padrões de um get e set
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

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

        //metodo tradicional para get e set
        //public double GetSaldo()
        //{
        //    return this._saldo;
        //}

        //public void SetSaldo(double saldo)
        //{
        //    if(saldo < 0)
        //    {
        //        return;
        //    }
        //    this._saldo = saldo;
        //}

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