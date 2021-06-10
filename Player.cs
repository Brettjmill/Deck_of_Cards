using System;
using System.Collections.Generic;

namespace Deck_of_Cards{
    public class Player
    {
        public string Name;

        public List<Card> Hand = new List<Card>();

        public Player(string inputName)
        {
            Name = inputName;
        }

        public Card DrawCard(Card drawnCard)
        {
            Hand.Add(drawnCard);
            return drawnCard;
        }

        public Card Discard(int tossedCardIdx)
        {
            if(tossedCardIdx < Hand.Count)
            {
                Card tossedCard = Hand[tossedCardIdx];
                Hand.RemoveAt(tossedCardIdx);
                return tossedCard;
            }
            else
            {
                return null;
            }
        }
    }
}