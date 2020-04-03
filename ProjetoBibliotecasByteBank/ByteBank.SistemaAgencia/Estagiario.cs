using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }
        //esta utilizando um modificador internal protected da classe Funcionario
        //como no Projeto ByteBank.Modelos ela é internal protected nesse projeto só utilizamos o protected
        //pois nessa classe ela esta derivando
        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
