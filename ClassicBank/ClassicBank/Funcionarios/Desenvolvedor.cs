using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(double salario, string cpf) : base(salario, cpf)
        {
            Console.WriteLine("Criando Desenvolvedor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.25;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
