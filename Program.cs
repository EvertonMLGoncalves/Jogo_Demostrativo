using Jogo_Demostrativo.Construtores;
using Jogo_Demostrativo.Decorator;
using Jogo_Demostrativo.Manager;
using Jogo_Demostrativo.Movimentação;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Demostrativo
{
    internal class Program
    {
        static void Main(string[] args) 
        { 
            /*//Construindo o Personagem//
            ConstrutorPersonagem construtor1 = new ConstrutorGuerreiro();
            Menu.EscolherPersonagem(construtor1);

            //Vendo sua força 
            IPersonagem personagem1 = construtor1.ObterPersonagem();
            Console.WriteLine(personagem1.Atacar()); // saida: 90 (Força base do Guerreiro)

            //Adicionando os Decorators// 
            //1°//
            personagem1 = new DecoratorFuria(personagem1);
            Console.WriteLine(personagem1.Atacar()); // saída: 110 (Aumento de 20 pontos)
            //2°// 
            personagem1 = new DecoratorImpeto(personagem1);
            Console.WriteLine(personagem1.Atacar()); // Saída: 140 (Aumento de 30 pontos) */

            //------------------------------------------------------------------------- 

            MovimentoPersonagem mov = new MovimentoPersonagem();

            IMovimentar frente = new MovimentoFrente(mov);
            IMovimentar tras = new MovimentoTras(mov);
            IMovimentar direita = new MovimentoDireita(mov);
            IMovimentar esquerda = new MovimentoEsquerda(mov); 
             
            Movimentacao movimento = new Movimentacao(frente, tras, direita, esquerda);

            movimento.AndarFrente(); // Saída: O Personagem está andando para frente
            movimento.AndarDireita(); // Saída: O Personagem está andando para frente

            Console.ReadKey();
        }
    }
}
