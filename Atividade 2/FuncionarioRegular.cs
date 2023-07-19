using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    public class FuncionarioRegular : Funcionario
    {
        public string Nome;
        public override void pessoa(string Nome)
        {
            Console.WriteLine($"FuncionarioRegular: {Nome}");
        }
        public override void valores(double SalarioBase)
        {
            Console.WriteLine($" Ganha 2000 ");
        }
    }
}
