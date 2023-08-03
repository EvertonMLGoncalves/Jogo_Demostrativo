using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Construtores
{
    internal class ConstrutorArqueiro : ConstrutorPersonagem
    { 
        public override void DefinirForca()
        {
            personagem.Forca = 80;
        }
        public override void DefinirClasse()
        {
            personagem.Classe = Enums.Classes.Arqueiro;
        }
        public override void DefinirDefesa()
        {
            personagem.Defesa = 60;
        }
        public override void DefinirHP()
        {
            personagem.HP = 120;
        }

        public override void DefinirId()
        {
            personagem.Id = Guid.NewGuid();
        }

        public override void DefinirNome()
        {
            Console.WriteLine("Digite o Nome do Arqueiro:");
            personagem.Nome = Console.ReadLine();
        }
        

        public override IPersonagem ObterPersonagem()
        {
            return personagem;
        }
    }
}
