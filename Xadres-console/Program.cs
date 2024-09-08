using System;
using tabuleiro;

namespace Xadres_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Posicao p = new Posicao(3, 4);

            Tabuleiro tab = new Tabuleiro(20, 20);

            Tela.imprimirTabuleiro(tab);

            Console.WriteLine();
            
        }
    }
}
