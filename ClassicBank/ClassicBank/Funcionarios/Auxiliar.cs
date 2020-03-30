using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBank.Funcionarios
{
    //dessa forma fazemos a herança, então Auxiliar está herdando todos os metodos da classe Funcionario
    public class Auxiliar : Funcionario
    {
        //nessa construtor deixamos como padrão o salario de 2000
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando Auxiliar");
        }

        //graças ao tipo protected podemos ter acesso ao setter de Salario da classe pai
        //e sobrescrever o metodo AumentarSalario para funcionar de forma diferente da classe base(pai)
        //*** o tipo virtual da classe pai nos permite sobrescrever e o tipo abstract nos obriga a criar sobrescrevendo esse metodo
        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
