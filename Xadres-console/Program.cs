using System;
using tabuleiro;
using xadrez;

namespace Xadres_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            posicaoXadrez pos = new posicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

        }
    }
}
