using ByteBank.Modelos;
using Humanizer;
using Humanizer.Localisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(245, 567889);
            Console.WriteLine(conta.Saldo);

            // Dia 17 de Agosto de 2020
            DateTime dataFimPagamento = new DateTime(2020, 5, 30);
            //Data corrente no momento de execução do código
            //***esse metodo é estático por isso conseguimos invocar dessa maneira
            DateTime dataCorrente = DateTime.Now;
            //Usamos o TimeSpan para calcular a diferença de tempo entre datas
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            //foi baixado para esse projeto o pacote NuGet Humanize que descreve quantos dias, semanas, meses e por ai vai, faltam entre as datas
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            //utilizando dessa maneira quando passar de 4 semanas a resposta será em meses, diferente da anterior que continuará exibindo em semanas
            string mensagemEmMes = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca, maxUnit: TimeUnit.Month);

            TimeSpan horas = TimeSpan.FromMinutes(80);
            string mensagemHoras = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(horas);


            Console.WriteLine(mensagem);
            Console.WriteLine(mensagemEmMes);
            Console.WriteLine(mensagemHoras);
            Console.ReadLine();
        }
    }
}
