using System;
using tabuleiro;

namespace Xadres_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao(3, 4);

            Console.WriteLine("Posição" + p);
        }
    }
}
