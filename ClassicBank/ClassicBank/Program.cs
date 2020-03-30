using ClassicBank.Funcionarios;
using ClassicBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
            
            // CalcularBonificacao();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();
            ParceiroComercial parceiro = new ParceiroComercial();

            parceiro.Senha = "123456";

            Diretor roberta = new Diretor("244.641.234-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta igor = new GerenteDeConta("457.132.644-04");
            igor.Nome = "Igor";
            igor.Senha = "abc";

            sistema.Logar(parceiro, "123456");
            sistema.Logar(roberta, "123");
            sistema.Logar(igor, "123");
            sistema.Logar(igor, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Desenvolvedor sillas = new Desenvolvedor(2500.0, "321.859.212-42");
            sillas.Nome = "Sillas"; 
            
            Funcionario carlos = new Auxiliar("451.276.255-01");
            carlos.Nome = "Carlos";

            Funcionario roberta = new Diretor("244.641.234-04");
            roberta.Nome = "Roberta";

            Funcionario pedro = new Designer("155.643,725-22");
            pedro.Nome = "Pedro";

            Funcionario igor = new GerenteDeConta("457.132.644-04");
            igor.Nome = "Igor";

            gerenciador.Registrar(sillas);
            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(pedro);
            gerenciador.Registrar(igor);


            Console.WriteLine("Total de bonificação do mês: " + gerenciador.GetBonificacao());
        }
    }
}
