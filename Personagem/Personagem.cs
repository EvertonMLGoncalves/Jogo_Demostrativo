using Jogo_Demostrativo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo
{
    internal class Personagem : IPersonagem
    { 
        public Guid Id { get; set; } 
        public string Nome { get; set; }  
        public Classes Classe { get; set; }
        public int HP { get; set; }
        public int Forca { get; set; } 
        public int Defesa { get; set; } 
        public virtual int Atacar()
        {
            return Forca;
        }

        public virtual int Defender()
        {
            return Defesa;
        }
    }
}
