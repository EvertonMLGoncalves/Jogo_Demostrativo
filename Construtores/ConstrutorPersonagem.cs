using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Construtores
{
    internal abstract class ConstrutorPersonagem
    { 
         protected Personagem personagem = new Personagem();

        public abstract void DefinirClasse();
        public abstract void DefinirDefesa();
        public abstract void DefinirId();
        public abstract void DefinirHP();
        public abstract void DefinirNome();
        public abstract void DefinirForca();

        public abstract IPersonagem ObterPersonagem();
    }
}
