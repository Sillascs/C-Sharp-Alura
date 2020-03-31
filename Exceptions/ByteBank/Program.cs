using System;
using System.Collections.Generic;
using System.IO;
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
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }


            //TestaInnerException();
            //TestaExcecoes();
            //DivisaoPorZero();

            Console.WriteLine("Fim da execução aperter enter para sair.");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            //o using tem a mesma função de um try com finally
            //e ele não libera os recursos do construtor Dispose quando seu valor é nulo  
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("text.txt"))
            {
                leitor.LerProximaLinha();
            }

            //------------------------------------------------------------------------------------------

            //LeitorDeArquivo leitor = null;
            ////a construção do try tem que ser com o catch ou finally ou ambos
            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada");
            //}
            ////finally será executado independente se foi achado uma exceção
            //// estamos garantindo que mesmo que ao abrir o arquivo e achado uma exceção ele seja fechado
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    //com esse if estamos garantindo que só será fechado o arquivo q for encontrado e abreto
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(253, 567385);
                ContaCorrente conta2 = new ContaCorrente(344, 345464);

                conta.Depositar(50);
                //conta.Sacar(600); //não tem a exceção InnerException no construtor que está utilizando, então quando for executar dará erro NullReferenceException
                conta2.Transferir(1000, conta);
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
        }

        private static void TestaExcecoes()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(253, 567385);
                ContaCorrente conta2 = new ContaCorrente(344, 345464);

                conta.Depositar(50);
                conta.Sacar(600);
                //conta.Sacar(-10);
                //conta2.Transferir(-10, conta);
            }
            //"e" ou "ex" é uma convenção usada para exceções
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            //***essa exceção foi usada antes de criar a OperacaoFinanceiraException que supre a utilização delas 
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
        }


        private static void DivisaoPorZero()
        {
            try
            {
                TestaDivisao(0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possível divisão por 0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
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
