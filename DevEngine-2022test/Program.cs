using DevEngine.Drawing;
using DevEngine.Engine;
using System;

namespace DevEngine_2022test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Test", 1920, 1080);
            Drawing drawing = new Drawing(game);
        }
    }
}
