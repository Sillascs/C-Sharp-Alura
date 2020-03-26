using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "431.896.004-45";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = gabriela;
            //conta.titular = new Cliente();

            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.profissao = "Desenvolvedora C#";
            //conta.titular.cpf = "431.896.004-45";

            if (conta.titular == null)
                Console.WriteLine("Ops, a referêcia em conta.titular é NULL");

            conta.saldo += 400;
            conta.agencia = 563;
            conta.numero = 5634527;

            Console.WriteLine(conta.titular);
            //Console.WriteLine(gabriela.nome);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.profissao);
            //Console.WriteLine(conta.titular.cpf);

            Console.ReadLine();
        }
    }
}
