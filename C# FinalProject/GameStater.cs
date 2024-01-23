using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    internal class GameStarter
    {
        private static void Main(string[] args)
        {
            Game gameInstance = new Game();
            gameInstance.StartGame(gameInstance);
        }
    }
}