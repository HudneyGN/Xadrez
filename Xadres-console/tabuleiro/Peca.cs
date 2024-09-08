using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    public class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } // protected acessada pela classe e pelas sub classes
        public int qteMovimentos { get; protected set; } // protected acessada pela classe e pelas sub classes
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
    }
} 
