using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pref
{
    internal class Deck
    {
        uint capacity;
        public List<Card> CardsInDeck { get; set; }
        internal enum DeckType {Full, RussianType, PreferanceType}

        public string[] CardSuit = { "Spades", "Clubs", "Diamonds", "Hearts" };
        public string[] CardValue = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        internal DeckType deck_type { get; set; }
        internal Deck(DeckType deckType) 
        {
            CardsInDeck = new List<Card>();
            deck_type = deckType;

            switch (deckType)
            {

                case DeckType.Full:
                    capacity = 52;
                    break;
                case DeckType.RussianType:
                    capacity = 36;
                    break;

                case DeckType.PreferanceType:
                    capacity = 32;
                    break;
                 default:
                 capacity = 52;
                 break;
            }            
        }
        internal void InitDeck()
        {
            foreach (var suit in CardSuit)
            {
                foreach (var value in CardValue)
                {
                    CardsInDeck.Add(new Card(suit, value));
                }
            }
            
            if (deck_type == DeckType.RussianType)
            {
               
            }
            if (deck_type == DeckType.PreferanceType)
            {

            }
        }
    }
}
