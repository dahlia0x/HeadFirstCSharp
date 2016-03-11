
namespace Cards
{
    public class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public Card(int suit, int value)
        {
            Suit = (Suits) suit;
            Value = (Values) value;
        }
    }
}
