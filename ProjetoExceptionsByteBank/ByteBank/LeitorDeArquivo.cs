using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    //para utilizar o using na class Program é necessario utilizar a interface IDisposable
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }
        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            
            //nessa exceção estamos simulando que o arquivo não foi encontrado
            //throw new FileNotFoundException();
            
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            //IOException é as exceções de entrada e saida do sistema
            //nesse exemplo estamos simulando um arquivo corrompido
            //throw new IOException();
            
            return "Linha do arquivo";
        }

        //public void Fechar()
        //{
        //    Console.WriteLine("Fechando arquivo.");
        //}

        //por contrato da interface IDisposable temos que usar o construtor Dispose que fará a mesma função que o construtor Fechar()
        //o Dispose é um metodo cuja a função é liberar os recursos
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
