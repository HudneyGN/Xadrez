﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    public class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        public override string ToString()
        {
            return this.linha
                + ", "
                + this.coluna;
        }
    }
}
