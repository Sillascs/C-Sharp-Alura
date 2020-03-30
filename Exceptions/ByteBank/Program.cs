using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            //"e" ou "ex" é uma convenção usada para exceções
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possível divisão por 0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                //ContaCorrente conta = null;
                //Console.WriteLine(conta.Saldo);
                return numero / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                //sem o throw o metodo Dividir não passaria a informação do erro de DivideByZeroException para o Main tratar
                //pois o throw relança a exceção
                throw;
            }
            
        }
    }
}
