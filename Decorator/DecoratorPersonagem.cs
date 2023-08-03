using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Decorator
{
    internal abstract class DecoratorPersonagem : Personagem, IPersonagem
    {
        protected IPersonagem personagem;

        protected DecoratorPersonagem(IPersonagem personagem)
        {
            this.personagem = personagem;
        }
        public override abstract int Atacar();
        public override abstract int Defender();
    }
}
