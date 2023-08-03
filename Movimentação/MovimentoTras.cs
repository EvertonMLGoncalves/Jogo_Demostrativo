using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Movimentação
{
    internal class MovimentoTras : IMovimentar
    {
        private MovimentoPersonagem movimento;
        public MovimentoTras(MovimentoPersonagem movimento)
        {
            this.movimento = movimento;
        }
        public void Movimentar()
        {
            movimento.ParaTras();
        }
    }
}
