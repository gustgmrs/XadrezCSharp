using System;
using _Tabuleiro;
using Xadrez.JogoXadrez;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                _Tabuleiro.Tabuleiro tab = new _Tabuleiro.Tabuleiro(8, 8);
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 3));
                
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(5, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 4));
                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            


        }
    }
}