using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Movimentação
{
    internal class MovimentoDireita : IMovimentar 
    {
        private MovimentoPersonagem movimento;
        public MovimentoDireita(MovimentoPersonagem movimento)  
        {  
            this.movimento = movimento;
        }
        public void Movimentar()
        {
            movimento.ParaDireita();
        }
    }
}
