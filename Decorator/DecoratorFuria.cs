using Jogo_Demostrativo.Construtores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Decorator
{
    internal class DecoratorFuria : DecoratorPersonagem
    {


        public DecoratorFuria(IPersonagem personagem) : base(personagem)
        {
        }

        public override int Atacar()
        {
            return base.personagem.Atacar() + 20;

        }
        public override int Defender()
        {
            return base.personagem.Defender() + 10;
        }


    }
}
