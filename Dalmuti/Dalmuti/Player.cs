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
    }
}
