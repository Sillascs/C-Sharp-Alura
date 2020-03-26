using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {

        private string _cpf;
        // atalho prop é template de estrutura de código para inserir o get e set
        public string Nome { get; set; }
        public string Profissao { get; set; }

        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escreva a lógica de validação do CPF
                _cpf = value;
            }
        }
    }
}
