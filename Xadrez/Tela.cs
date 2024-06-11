﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Tabuleiro;
using Xadrez.JogoXadrez;

namespace Xadrez
{
    public class Tela
    {

        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            Console.Clear();
            Console.WriteLine();
            Tela.ImprimirTabuleiro(partida.Tab);
            Console.WriteLine();

            ImprimirPecasCapturadas(partida);

            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.Turno);
            Console.WriteLine("Aguardando jogada da peças: " + partida.JogadorAtual + "s.");
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Pecas Capturadas: ");

            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));

            Console.WriteLine();

            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach (Peca peca in conjunto)
            {
                Console.Write(peca + " ");
            }
            Console.Write("]");
        }
        public static void ImprimirTabuleiro(_Tabuleiro.Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + "  ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    ImprimirPeca(tab.Peca(i,j));
                }
                
                Console.WriteLine();
            }
            
            Console.WriteLine("   a b c d e f g h");
        }

        public static void ImprimirTabuleiro(_Tabuleiro.Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + "  ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }

                    ImprimirPeca(tab.Peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }

                Console.WriteLine();
            }

            Console.WriteLine("   a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }

            else
            {

                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }

                Console.Write(" ");
            }
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez(coluna, linha);
        }
    }
}
