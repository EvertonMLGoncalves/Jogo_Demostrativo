using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Movimentação
{
    internal class Movimentacao
    {
        private IMovimentar ParaFrente;
        private IMovimentar ParaTras;
        private IMovimentar ParaDireita;
        private IMovimentar ParaEsquerda;

        public Movimentacao(IMovimentar paraFrente, IMovimentar paraTras, IMovimentar paraDireita, IMovimentar paraEsquerda)
        {
            ParaFrente = paraFrente;
            ParaTras = paraTras;
            ParaDireita = paraDireita;
            ParaEsquerda = paraEsquerda;
        }

        public void AndarFrente()
        {
            ParaFrente.Movimentar();
        }
        public void AndarTras()
        {
            ParaTras.Movimentar();
        }
        public void AndarDireita()
        {
            ParaDireita.Movimentar();
        }
        public void AndarEsquerda()
        {
            ParaEsquerda.Movimentar();
        }
    }
}
