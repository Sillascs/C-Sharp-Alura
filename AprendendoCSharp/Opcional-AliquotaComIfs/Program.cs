using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_AliquotaComIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando exercicio opcional - Alíquota com ifs.");

            double salario = 3300.0;

            if (salario >= 3751.01 && salario <= 4664.0)
                Console.WriteLine("A sua alíquota é de 22.5% e pode deduzir até R$ 636");
            else if (salario >= 2800.01 && salario <= 3751.0)
                Console.WriteLine("A sua alíquota é de 15% e pode deduzir até R$ 350");
            else if (salario >= 1900.0 && salario <= 2800.0)
                Console.WriteLine("A sua alíquota é de 7.5% e pode deduzir até R$ 142");
            Console.ReadLine();
        }
    }
}
