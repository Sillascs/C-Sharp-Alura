using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBank.Funcionarios
{
    //aqui estamos dizendo que a classe funcionario é abstrata, que ela não deve ser diretamente instanciada pois tem classes derivadas dela
    public abstract class Funcionario
    {
        public static int TotalDeFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        //o tipo protected dá acesso ao metodo que está sendo protegito para as classes filhas e continua sendo privado para as classes de fora
        public double Salario { get; protected set; }

        //metodo construtor
        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionario++;
        }


        //virtual permite que classes filhas possam sobrescrever esse metodo
        //public virtual void AumentarSalario()
        //{
        //    Salario *= 1.10;
        //}

        //public virtual double GetBonificacao()
        //{
        //    return Salario * 0.10;
        //}

        //colocando metodos abstratos obriga as classes filhas a utilizarem os metodos
        //lembrando que metodos abstratos só funcionam em classes abstratas (igualmente as estaticas)
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

    }
}
