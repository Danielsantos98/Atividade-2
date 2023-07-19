using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    public class Gerente : Funcionario
    {
        public override void pessoa(string Nome)
        {
            Console.WriteLine($" Gerente ");
        }
        public override void valores(double SalarioBase)
        {
            Console.WriteLine($"  Ganha 3000 ");
        }
    }
}
