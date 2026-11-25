namespace CardsApp;

public class Deck
{
    private List<Card> cards;

    public Deck()
    {
        
        int numberOfSuits = 4;
        int numberOfRanks = 13;
        
        for (int suitIndex = 0; suitIndex < numberOfSuits; suitIndex++  ) 
        {
            for (int rankIndex = 0; rankIndex < numberOfRanks; rankIndex++)
            {
                Suit suit = (Suit)suitIndex;
                Rank rank = (Rank)rankIndex;
                Card card = new Card(suit, rank);
                cards?.Add(card);
            }
        }
    }
    
    public Card GetRandomCard()
    {
        Random rnd = new Random();
        int randomCardIndex = rnd.Next(0, cards.Count);
        return cards[randomCardIndex];
    }

    public Card GetTopCard()
    {
        return cards[0];
    }
}