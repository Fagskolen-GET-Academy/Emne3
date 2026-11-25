namespace CardsApp;

public class Card
{
    public Suit Suit { get;}
    public Rank Rank { get;}
    
    private static int cardCount  = 0;

    public Card(Suit suit, Rank rank)
    {
        Suit = suit;
        Rank = rank;
        cardCount++;
    }

    public static void HowManyCardsCreated()
    {
        Console.WriteLine($"You have made {cardCount} cards.");
    }


    
    
}