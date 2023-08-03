using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Movimentação
{
    internal class MovimentoPersonagem
    { 
        public void ParaFrente() 
        {
            Console.WriteLine("O personagem está andando para frente");
        }
        public void ParaTras()
        {
            Console.WriteLine("O personagem está andando para trás");
        }
        public void ParaDireita()
        {
            Console.WriteLine("O personagem está andando para direita");
        }
        public void ParaEsquerda()
        {
            Console.WriteLine("O personagem está andando para esquerda");
        }
    }
}
