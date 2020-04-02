using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class TesteTiposDeModificadores
    {
        public TesteTiposDeModificadores()
        {
            ModificadoresTeste teste = new ModificadoresTeste();

            teste.MetodoPublico(); // funciona
            //teste.MetodoProtegido(); // só vai funcionar na sua classe ou em classes derivadas de ModificadoresTeste
            //teste.MetodoPrivado(); // só vai funcionar na sua classe
            teste.MetodoInterno(); // funciona
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            //como é uma classe derivada não precisamos instanciar
            MetodoPublico(); // funciona
            MetodoProtegido(); // funciona
            //MetodoPrivado();// só vai funcionar na sua classe
            MetodoInterno(); // funciona
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // Visível fora da classe "ModificadoresTeste"
        }
        protected void MetodoProtegido()
        {
            // Visível apenas na classe "ModificadoresTeste" e derivados dela
        }
        private void MetodoPrivado()
        {
            // Visível apenas na classe "ModificadoresTeste"
        }
        //padrao é que qndo não definimos nenhum tipo de modificador ele já assume o internal
        internal void MetodoInterno()
        {
            // Visível apenas para o projeto ByteBank.Modelos
        }
        // internal protected é um tipo de modificador
        // olhar sua implementação na classe funcionario, nas derivadas como diretor, auxiliar, entre outras, e olhar na derivada do projeto Sistema.Internos classe Estagiario
        internal protected void MetodoInternoProtegido()
        {
            // Visível apenas para esse projeto e classes derivadas dessa em projetos externos, sendo que na classe do projeto derivado vc só vai usar o tipo protected
            //ver nos exemplos
        }
    }
}
