﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using XadrezConsole.tabuleiro;

namespace XadrezConsole.Jogo
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}