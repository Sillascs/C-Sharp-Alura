using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13");

            // escrevendo asterisco com BREAK
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            // outra maneira de escrever asterisco
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // tabuada

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * "+ contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // multiplos de 3 1ª Opção

            for (int divisor = 1; divisor <= 100; divisor++)
            {
                if(divisor % 3 == 0)
                {
                    Console.WriteLine(divisor);
                }
            }

            // multiplos de 3 2ª Opção

            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
