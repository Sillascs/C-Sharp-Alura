using ClassicBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBank.Funcionarios
{
    //existe uma ordem para herança primeiro a classe e depois as interfaces
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }
        public string Senha { get; set; }

        //quando é interface não é preciso escrever o override, pois é esperado que voce implemete esse metodo
        //que foi contratado da interface
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
