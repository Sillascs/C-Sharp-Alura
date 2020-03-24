using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1275.99;

            // o int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salario);

            // o long é uma variável de até 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // o short é um tipo de variável de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            // por padrão o c# vai reconhecer numeros decimais como double pois o float perde precisão em decimal
            // para que o c# reconheça como float depois das casas decimais acrescentamos o f
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
