using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalmuti
{
    class Game
    {
        // deck of cards for use in the game
        private Deck gameDeck;
        // players in the game
        private Player[] players;

        public Game(int playerCount)
        {
            players = new Player[playerCount];
            gameDeck = new Deck();

            // TESTING CARDS OUTPUT
            gameDeck.outputCards();
        }
    }
}
