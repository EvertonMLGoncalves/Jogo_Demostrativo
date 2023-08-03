using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Decorator
{
    internal class DecoratorImpeto : DecoratorPersonagem
    {
        public DecoratorImpeto(IPersonagem personagem) : base(personagem)
        {
        }
        public override int Atacar()
        {
            return base.personagem.Atacar() + 30;
        }

        public override int Defender()
        {
            return base.personagem.Defender() + 20;
        }
    }
}
