using Jogo_Demostrativo.Construtores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo.Manager
{
    internal static class Menu
    { 
        public static void EscolherPersonagem(ConstrutorPersonagem construtor)
        {
            construtor.DefinirNome();
            construtor.DefinirId(); 
            construtor.DefinirHP(); 
            construtor.DefinirForca();
            construtor.DefinirDefesa(); 
            construtor.DefinirClasse();
        } 
        
    }
}
