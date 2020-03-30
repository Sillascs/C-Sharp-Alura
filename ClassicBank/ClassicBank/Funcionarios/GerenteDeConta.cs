using ClassicBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBank.Funcionarios
{
    //dessa forma fazemos a herança, então Diretor está herdando todos os metodos da classe Funcionario
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        //nessa construtor deixamos como padrão o salario de 5000
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Gerente de Conta");
        }

        //graças ao tipo protected podemos ter acesso ao setter de Salario da classe pai
        // e sobrescrever o metodo AumentarSalario para funcionar de forma diferente da classe base(pai)
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        //override sobrescreve o metodo identico na classe pai
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
