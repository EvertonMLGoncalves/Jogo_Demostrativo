using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Movimentação
{
    internal class MovimentoFrente : IMovimentar
    {
        private MovimentoPersonagem movimento;
        public MovimentoFrente(MovimentoPersonagem movimento)
        {
            this.movimento = movimento;
        }
        public void Movimentar()
        {
            movimento.ParaFrente();
        }
    }
}
