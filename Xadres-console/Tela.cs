﻿using System;
using tabuleiro;

namespace Xadres_console
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j=0; j<tab.colunas; j++)
                {
                    if(tab.peca(i, j) == null)
                    {
                        Console.Write("_ ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write("");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
