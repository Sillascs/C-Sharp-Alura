using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Titular = new Cliente();

            conta.Titular.Nome = "Sillas Carneiro";
            //não vai compilar pois o saldo agora é privado, para evitar casos em q o saldo seja colocado negativo;
            //conta.saldo = -10;
            //dessa forma pela regra de negócio esse valor não vai ser definido;
            conta.Saldo = -10;
            Console.WriteLine(conta.Saldo);
            
            conta.Saldo = 200;
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
