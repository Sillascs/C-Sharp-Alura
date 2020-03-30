using ClassicBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicBank
{
    class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        //quando é interface não é preciso escrever o override, pois é esperado que voce implemete esse metodo
        //que foi contratado da interface
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
