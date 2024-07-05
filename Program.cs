using System;

namespace WorkingWithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();

            char symbol = 'H';
            int positionX = 5;
            int positionY = 5;

            Player player = new Player(symbol, positionX, positionY);

            renderer.Draw(player.PositionX, player.PositionY, symbol);
        }
    }

    class Player
    {
        public char Symbol { get; private set; }
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Player(char symbol, int positionX, int positionY)
        {
            Symbol = symbol;
            PositionX = positionX;
            PositionY = positionY;
        }
    }

    class Renderer
    {
        public void Draw(int positionX, int positionY, char symbol = '@')
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
            Console.ReadKey(true);
        }
    }
}
