using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalmuti
{
    class Player
    {
        // name of the player
        private string name;
        // cards in a player's hand
        private List<Card> hand;
        // temporary rank of a player in a given round
        private string rank;

        public Player() { }

        // creates a player with a given name
        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();
        }

        // adds a card to the player's hand
        public void addCardToHand(Card c)
        {
            hand.Add(c);
        }

        // TESTING: Outputs the player's hand
        public void outputHand()
        {
            Console.WriteLine("\n" + name + "'s Hand");
            foreach(Card c in hand)
            {
                Console.WriteLine(c.getName() + ", " + c.getValue());
            }
        }

        // gives rank to player (e.g. Greater Dalmuti, Merchant, Lesser Peon, etc.)
        public void setRank(string rank)
        {
            this.rank = rank;
        }

        public string getRank()
        {
            return rank;
        }

        public void resetHand()
        {
            hand.Clear();
        }
    }
}
