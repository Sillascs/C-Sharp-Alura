﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            // será impresso 20
            Console.WriteLine(idade);
            // será impresso 32
            Console.WriteLine(idadeGustavo);

            Console.ReadLine();
        }
    }
}
