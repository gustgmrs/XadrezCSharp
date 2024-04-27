using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Tabuleiro;

namespace Xadrez.JogoXadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
