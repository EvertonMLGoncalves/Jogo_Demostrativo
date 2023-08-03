using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Movimentação
{
    internal class MovimentoEsquerda : IMovimentar
    {
        private MovimentoPersonagem movimento;
        public MovimentoEsquerda(MovimentoPersonagem movimento)
        {
            this.movimento = movimento;
        }
        public void Movimentar()
        {
            movimento.ParaEsquerda();
        }
    }
}
