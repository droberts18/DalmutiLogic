using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalmuti
{
    class Deck
    {
        // All the cards in the game
        private Card[] cards;
        // Points to the index of the next empty element in cards array (used only in creation of deck)
        private int cardsIndex;
        // Connects a value to a specific name (e.g. all 12's are Peasants, 2's are Archbishops, etc.)
        private Dictionary<int, string> cardValuesAndNames;

        public Deck()
        {
            // creates a new array of cards, size 80 for all cards in the real life game
            cards = new Card[80];
            // sets cardIndex to 0, the first empty element in the cards array
            cardsIndex = 0;
            cardValuesAndNames = new Dictionary<int, string>();
            initializeCards();
            // shuffles cards on creation of entire deck
            shuffleCards();
        }

        // creates all possible cards (uses cards dictionary), adds them to the cards array
        private void initializeCards()
        {
            // creating dictionary for creating correct cards
            initializeCardDict();

            // creating the two jesters
            createCard(13);
            createCard(13);

            // creating the rest of the deck based on real cards (e.g. 12 12's, 11 11's, 10 10's, etc.)
            // goes through each value from 12 down to 1
            for(int cardValue = 12; cardValue > 0; cardValue--)
            {
                // creates specific number of cards (based on the card's value) of the specific cardValue
                for(int cardCount = cardValue; cardCount > 0; cardCount--)
                {
                    createCard(cardValue);
                }
            }
        }

        // sets up the cardValuesAndNames array to have the correct correspondence between card values and respective names
        private void initializeCardDict()
        {
            cardValuesAndNames.Add(13, "Jester");
            cardValuesAndNames.Add(12, "Peasant");
            cardValuesAndNames.Add(11, "Stonecutter");
            cardValuesAndNames.Add(10, "Shepherdess");
            cardValuesAndNames.Add(9, "Cook");
            cardValuesAndNames.Add(8, "Mason");
            cardValuesAndNames.Add(7, "Seamstress");
            cardValuesAndNames.Add(6, "Knight");
            cardValuesAndNames.Add(5, "Abbess");
            cardValuesAndNames.Add(4, "Baroness");
            cardValuesAndNames.Add(3, "Earl Marshal");
            cardValuesAndNames.Add(2, "Archbishop");
            cardValuesAndNames.Add(1, "Dalmuti");
        }

        // creates a card based on the value passed, adds to cards array
        private void createCard(int cardValue)
        {
            // gets corresponding card name based on cardValue
            string cardName = cardValuesAndNames[cardValue];
            cards[cardsIndex++] = new Card(cardName, cardValue);
        }

        public void shuffleCards()
        {
            Random rdm = new Random();

            for(int i = 0; i < 100000; i++)
            {
                // getting two random cards
                int swapIndex1 = rdm.Next(cards.Length);
                int swapIndex2 = rdm.Next(cards.Length);

                // classic swap function, swaps the two random cards placement in deck
                Card temp = cards[swapIndex1];
                cards[swapIndex1] = cards[swapIndex2];
                cards[swapIndex2] = temp;
            }
        }

        // TESTING PURPOSES: Outputs all cards, with their values and names
        public void outputCards()
        {
            foreach(Card c in cards)
            {
                Console.WriteLine(c.getName() + ", " + c.getValue());
            }
        }
    }
}
