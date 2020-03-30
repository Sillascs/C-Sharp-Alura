using ClassicBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBank.Sistema
{
    //o I antes do nome da interface é uma conveção para identificar que é do tipo interface
    //interface nunca tera implementação e nem tipo de visibilidade para seus metodos pois todos seus membros são publicos
    //interface é um contrato, que a classe que aderir tera que implementar seus metodos
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
