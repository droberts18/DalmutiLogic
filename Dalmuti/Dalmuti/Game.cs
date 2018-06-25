using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalmuti
{
    class Game
    {
        // the deck of cards for use in the game
        Deck gameDeck;
        // contains players?

        public Game()
        {
            gameDeck = new Deck();

            // TESTING CARDS OUTPUT
            gameDeck.outputCards();
        }
    }
}
