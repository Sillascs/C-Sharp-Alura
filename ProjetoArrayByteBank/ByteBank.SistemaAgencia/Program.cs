using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(675, 34435),
                new ContaCorrente(675, 45665),
                new ContaCorrente(675, 52197)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} Agência: {contaAtual.Agencia} Numero: {contaAtual.Numero}");
            }

            Console.ReadLine();
        }
        static void TestaArrayInt()
        {
            //ARRAY DE NUMEROS INTEIROS COM 5 POSIÇÕES
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 42;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            Console.WriteLine(idades.Length);
            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idades[indice];
            }

            int media = acumulador / idades.Length;

            Console.WriteLine($"A média de todas as idades é {media}");

            Console.ReadLine();
        }
    }
}


