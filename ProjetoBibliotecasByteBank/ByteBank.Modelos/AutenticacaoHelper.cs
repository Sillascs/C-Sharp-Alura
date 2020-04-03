using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    // quando usamos o modificador de acesso internal declaramos que apenas os que estão no projeto ByteBank.Modelos terá acesso a essa classe
    // se não colocarmos nenhum tipo de visibilidade na classe ela já assume o tipo internal
    internal class AutenticacaoHelper
    {
        public bool CompararSenha(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
