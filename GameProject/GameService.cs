using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameService : IGameManager
    {
        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " sold to " + gamer.FirstName + " for $" + game.GamePrice);
        }
    }
}
