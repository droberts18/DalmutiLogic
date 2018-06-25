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
        // number of players in game
        private int playerCount;
        // players in the game
        private Player[] players;

        public Game()
        {
            setupPlayers();
            // setup deck
            gameDeck = new Deck();
            // TODO: Input logic for user to decide how many rounds to play? Maybe stop whenever the user decides?
            playRound();
        }

        // calls all functions necessary to setup all players
        private void setupPlayers()
        {
            enterPlayerCount();
            players = new Player[playerCount];
            enterPlayerNames();
        }

        // gets a valid number of players from the user
        private void enterPlayerCount()
        {
            Console.WriteLine("How many players are there?");
            bool validNumOfPlayers = false;

            do
            {
                // if the user has entered a number between 3 and 8, inclusive
                if ((int.TryParse(Console.ReadLine(), out playerCount)) && playerCount >= 3 && playerCount <= 8)
                {
                    validNumOfPlayers = true;
                }
                else
                {
                    Console.WriteLine("Not a valid number of players (3-8 is valid). Let's try again, how many players are there?");
                }
            } while (!validNumOfPlayers);
        }

        // gets user-entered names for all players
        private void enterPlayerNames()
        {
            for(int playerIndex = 0; playerIndex < players.Length; playerIndex++)
            {
                Console.Write("\nPlease enter a name for Player #" + (playerIndex + 1) + ": ");
                string playerName = Console.ReadLine();
                players[playerIndex] = new Player(playerName);
            }
        }

        // calls all functions necessary to play a round (TODO: complete function to suit game rules and specifications)
        private void playRound()
        {
            gameDeck.shuffleCards();
            distributeCards();

            outputPlayersHands();

            // TODO: create main game logic

            // resetPlayerHands();
        }

        // distributes cards to all players
        // TODO: add logic to give the Dalmuti's the hands with more cards should the deck not divide evenly amongst all players
        private void distributeCards()
        {
            // index of the player to recieve the next card
            int playerIndex = 0;

            foreach(Card c in gameDeck.getCards())
            {
                players[playerIndex++].addCardToHand(c);

                // checks to see if the last player has received a card and if so, the next player to receive a card is the first player
                if (playerIndex >= playerCount)
                    playerIndex = 0; 
            }
        }

        // deletes all cards from each player's hand at the end of each round
        private void resetPlayerHands()
        {
            foreach(Player p in players)
            {
                p.resetHand();
            }
        }

        // TESTING: Outputs all player's hands
        private void outputPlayersHands()
        {
            foreach(Player p in players)
            {
                p.outputHand();
            }
        }
    }
}
