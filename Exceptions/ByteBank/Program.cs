﻿using System;
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
                ContaCorrente conta = new ContaCorrente(253, 567385);
                ContaCorrente conta2 = new ContaCorrente(344, 345464);

                conta.Depositar(50);
                //conta.Sacar(600);
                //conta.Sacar(-10);
                conta2.Transferir(1000, conta);
                //conta2.Transferir(-10, conta);
            }
            //"e" ou "ex" é uma convenção usada para exceções
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);

                try
                {
                    //Informações da INNER EXCEPTION (exceção interna):
                    Console.WriteLine(e.InnerException.StackTrace);
                    
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            //catch (SaldoInsuficientException ex)
            //{
            //    Console.WriteLine("Ocorreu uma exceção do tipo SaldoInsuficientException");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //}

            //try
            //{
            //    Metodo();
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Não é possível divisão por 0");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //}
            
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
