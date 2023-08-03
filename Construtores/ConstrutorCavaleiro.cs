using Jogo_Demostrativo.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Construtores
{
    internal class ConstrutorCavaleiro : ConstrutorPersonagem
    {
        public override void DefinirForca()
        {
            personagem.Forca = 95;
        }
        public override void DefinirClasse()
        {
            personagem.Classe = Enums.Classes.Cavaleiro;
        }
        public override void DefinirDefesa()
        {
            personagem.Defesa = 100;
        }
        public override void DefinirHP()
        {
            personagem.HP = 180;
        }

        public override void DefinirId()
        {
            personagem.Id = Guid.NewGuid();
        }

        public override void DefinirNome()
        {
            Console.WriteLine("Digite o Nome do Cavaleiro:");
            personagem.Nome = Console.ReadLine();
        }
        public override IPersonagem ObterPersonagem()
        {
            return personagem;
        }


    }
}
