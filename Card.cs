namespace Deck_of_Cards{
    public class Card
    {
        public string StringVal;
        public string Suit;
        public int Val;

        public Card(string inputStringVal, string inputSuit, int inputVal)
        {
            StringVal = inputStringVal;
            Suit = inputSuit;
            Val = inputVal;
        }
    }
}