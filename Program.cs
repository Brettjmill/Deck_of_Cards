using System;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Steve");

            Deck deck1 = new Deck();

            deck1.ShuffleDeck();

            player1.DrawCard(deck1.Deal());
            player1.DrawCard(deck1.Deal());
            player1.DrawCard(deck1.Deal());
            player1.DrawCard(deck1.Deal());
            player1.DrawCard(deck1.Deal());

            for (int i = 0; i < player1.Hand.Count; i++)
            {
                Console.WriteLine("{0} of {1}", player1.Hand[i].StringVal, player1.Hand[i].Suit);
            }

            player1.Discard(0);

            for (int i = 0; i < player1.Hand.Count; i++)
            {
                Console.WriteLine("{0} of {1}", player1.Hand[i].StringVal, player1.Hand[i].Suit);
            }
        }
    }
}
