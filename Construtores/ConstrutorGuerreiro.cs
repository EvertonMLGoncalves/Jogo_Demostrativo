using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Construtores
{
    internal class ConstrutorGuerreiro : ConstrutorPersonagem
    {
        public override void DefinirForca()
        {
            personagem.Forca = 90;
        }
        public override void DefinirClasse()
        {
            personagem.Classe = Enums.Classes.Guerreiro;
        }
        public override void DefinirDefesa()
        {
            personagem.Defesa = 80;
        }
        public override void DefinirHP()
        {
            personagem.HP = 150;
        }

        public override void DefinirId()
        {
            personagem.Id = Guid.NewGuid();
        }

        public override void DefinirNome()
        {
            Console.WriteLine("Digite o Nome do Guerreiro:"); 
            personagem.Nome = Console.ReadLine();
        }
        public override IPersonagem ObterPersonagem()
        {
            return personagem;
        }

    }
}
