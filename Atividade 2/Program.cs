// See https://aka.ms/new-console-template for more information

using System;

namespace Atividade_2
{
    class program
    {
        static void Main()
        {
            ///SBFR =SalarioBaseFuncionarioRegular
            ///SBE =SalarioBaseEstagiario
            ///SBG =SalarioBaseGerente

            Funcionario SBFR = new FuncionarioRegular();
            SBFR.valores(2000);

            Funcionario SBE = new Estagiario();
            SBE.valores(1000);

            Funcionario SBG = new Gerente();
            SBG.valores(3000);

            Funcionario SBFR2 = new FuncionarioRegular();
            SBFR2.pessoa(Daniel1);

            Funcionario SBE2 = new Estagiario();
            SBE2.pessoa(Daniel2);

            Funcionario SBG2 = new Gerente();
            SBG2.pessoa(Daniel3);
        }
    }
}
