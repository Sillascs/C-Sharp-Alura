using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

            double salario = 1200.70;

            Console.WriteLine(salario);

            double numero = 15 / 2;

            Console.WriteLine("Aparecerá o numero inteiro: " + numero); // pois na declaração da variavel, foi declarado dois numeros do tipo inteiro

            numero = 15.0 / 2; // para que a fração seja apresentada da forma correta precisamos declarar dessa forma

            Console.WriteLine("Agora aparecerá da forma correta: " + numero);

            Console.WriteLine("Execução finalizada. Tecle enter para encerrar");
            Console.ReadLine();
        }
    }
}
