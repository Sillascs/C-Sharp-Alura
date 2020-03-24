using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            // character, aceita apenas 1 caracter
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            // se for trabalharmos com numeros inteiros em char precisamos converter (casting)
            primeiraLetra = (char)65;
            // resultado será A, segundo a ascii table
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            // resultado será B, segundo a ascii table
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            string cursosProgramacao = @" - .Net
 - Java
 - Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            Console.ReadLine();
        }
    }
}
