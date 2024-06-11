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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    try
                    {
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.validarPosicaoOrigem(origem);

                        bool[,] possicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, possicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException exc)
                    {
                        Console.WriteLine(exc.Message);
                        Console.ReadLine();
                    }
                    
                }
        }
    }
}