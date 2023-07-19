using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    public class Estagiario : Funcionario
    {
        public override void pessoa(string Nome)
        {
            Console.WriteLine($" Estagiario");
        }
        public override void valores(double SalarioBase)
        {
            Console.WriteLine($" Ganha 1000 ");
        }
    }
}
