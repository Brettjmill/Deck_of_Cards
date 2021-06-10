using System;
using System.Collections.Generic;

namespace Deck_of_Cards{
    class Deck
    {
        public List<Card> NewDeck;

        public List<Card> FreshDeck;

        public Deck()
        {
            string[] suitArray = {"Clubs","Hearts","Spades","Diamonds"};
            string[] stringValArray = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            int[] valArray = {1,2,3,4,5,6,7,8,9,10,11,12,13};

            NewDeck = new List<Card>();
            
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    NewDeck.Add(new Card(stringValArray[j], suitArray[i], valArray[j]));
                }
            }

        }

        public Card Deal()
        {
            Card DealtCard = NewDeck[0];
            NewDeck.RemoveAt(0);
            return DealtCard;
        }

        public List<Card> ResetDeck()
        {
            string[] suitArray = {"Clubs","Hearts","Spades","Diamonds"};
            string[] stringValArray = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            int[] valArray = {1,2,3,4,5,6,7,8,9,10,11,12,13};

            FreshDeck = new List<Card>();
            
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    FreshDeck.Add(new Card(stringValArray[j], suitArray[i], valArray[j]));
                }
            }

            NewDeck = FreshDeck;
            return NewDeck;
        }

        public List<Card> ShuffleDeck()
        {
            Random rand = new Random();

            for (int i = 0; i < NewDeck.Count; i++)
            {
                int temp = rand.Next(0,NewDeck.Count);
                Card tempCard = NewDeck[i];
                NewDeck[i] = NewDeck[temp];
                NewDeck[temp] = tempCard;
            }

            return NewDeck;
        }
    }
}