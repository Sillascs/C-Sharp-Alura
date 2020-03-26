using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGarbiela = new ContaCorrente();
            contaDaGarbiela.titular = "Gabriela";

            Console.WriteLine("Conta do Bruno: R$ " + contaDoBruno.saldo);
            Console.WriteLine("Conta da Gabriela: R$ " + contaDaGarbiela.saldo);

            bool resultadoTransferencia = contaDoBruno.Trasferir(200, contaDaGarbiela);

            Console.WriteLine("Conta do Bruno: R$ " + contaDoBruno.saldo);
            Console.WriteLine("Conta da Gabriela: R$ " + contaDaGarbiela.saldo);
            Console.WriteLine("Resultado da Transferência: " + resultadoTransferencia);

            Console.ReadLine();

        }
    }
}
