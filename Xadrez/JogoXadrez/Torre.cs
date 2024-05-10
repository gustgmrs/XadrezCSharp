using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Tabuleiro;

namespace Xadrez.JogoXadrez
{
    public class Torre : Peca
    {
        public Torre(_Tabuleiro.Tabuleiro tab, Cor cor) : base(cor, tab) { }

        public override string ToString()
        {
            return "T";
        }
    }
}